using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace VIZCore3D.NET.ImportAttribute
{
    /// <summary>
    /// AVEVA Attribute Manager
    /// </summary>
    public class ShxAttributeHelper
    {
        #region OutputLogEvent - 출력 로그 이벤트
        /// <summary>
        /// 출력 로그 이벤트
        /// </summary>
        public event OutputLogEventHandler OutputLogEvent;
        #endregion

        /// <summary>
        /// Attribute Files
        /// </summary>
        public string[] AttributeFiles { get; set; }

        /// <summary>
        /// Attribute List Map
        /// </summary>
        public Dictionary<string, List<ShxAttributeNode>> AttributeListMap { get; set; }
        /// <summary>
        /// Attribute Root Map
        /// </summary>
        public Dictionary<string, ShxAttributeNode> AttributeRootMap { get; set; }
        /// <summary>
        /// Attribute List
        /// </summary>
        public List<List<ShxAttributeNode>> AttributeList { get; set; }

        
        /// <summary>
        /// 포함 필터
        /// </summary>
        public Dictionary<string, string> FilterInclude { get; set; }

        /// <summary>
        /// 제외 필터
        /// </summary>
        public Dictionary<string, string> FilterExclude { get; set; }

        /// <summary>
        /// Attribute File Path
        /// </summary>
        public string AttributePath { get; set; }

        /// <summary>
        /// Construction
        /// </summary>
        public ShxAttributeHelper()
        {
            AttributeRootMap = new Dictionary<string, ShxAttributeNode>();
            AttributeList = new List<List<ShxAttributeNode>>();
            AttributeListMap = new Dictionary<string, List<ShxAttributeNode>>();
        }

        /// <summary>
        /// Import Attribute Files
        /// </summary>
        /// <param name="files">File List</param>
        public void ImportAttribute(string[] files)
        {
            foreach (string file in files)
            {
                ParseAttributeFile(file);
            }
        }

        /// <summary>
        /// Clear Attribute
        /// </summary>
        public void ClearAttribute()
        {
            AttributeRootMap.Clear();
            AttributeList.Clear();
            AttributeListMap.Clear();
        }

        private void ParseAttributeFile(string file)
        {
            ShxAttributeNode root = null;
            List<ShxAttributeNode> nodes = null;

            ParseAttribute(file, out root, out nodes, String.Empty);

            string key = System.IO.Path.GetFileNameWithoutExtension(file).ToUpper();

            if (AttributeListMap.ContainsKey(key) == false)
            {
                AttributeListMap.Add(key, nodes);
                AttributeList.Add(nodes);
            }

            if (AttributeRootMap.ContainsKey(key) == false)
                AttributeRootMap.Add(key, root);
        }

        private void ParseAttribute(string file, out ShxAttributeNode root, out List<ShxAttributeNode> nodes, string prefixNodePath)
        {
            root = new ShxAttributeNode(prefixNodePath);
            root.AttributeFileName = file; // 파일 이름 설정
            nodes = new List<ShxAttributeNode>();

            System.IO.StreamReader stream = new System.IO.StreamReader(file);

            while (true)
            {
                string str = stream.ReadLine();

                if (String.IsNullOrEmpty(str) == true)
                    break;

                if (str.Trim() == "NEW Header Information") continue;
                if (str.Trim().StartsWith("NEW") == false) continue;

                root.ParentNode = null;
                nodes.Add(root);
                root.SetNode(stream, str, nodes);
                break;
            }

            stream.Close();
        }

        /// <summary>
        /// 포함 필터
        /// </summary>
        /// <param name="filter">필터 문자열(콤마 ',' 로 구분된 문자열)</param>
        public void SetIncludeFilter(string filter)
        {
            FilterInclude = new Dictionary<string, string>();

            if (String.IsNullOrEmpty(filter) == true) return;

            string[] include = filter.Split(
                new char[] { ',' }
                , StringSplitOptions.RemoveEmptyEntries
                );

            foreach (string item in include)
            {
                if (FilterInclude.ContainsKey(item) == false)
                    FilterInclude.Add(item.ToUpper(), item.ToUpper());
            }
        }

        /// <summary>
        /// 제외 필터
        /// </summary>
        /// <param name="filter">필터 문자열(콤마 ',' 로 구분된 문자열)</param>
        public void SetExcludeFilter(string filter)
        {
            FilterExclude = new Dictionary<string, string>();

            if (String.IsNullOrEmpty(filter) == true) return;

            string[] exclude = filter.Split(
                new char[] { ',' }
                , StringSplitOptions.RemoveEmptyEntries
                );

            foreach (string item in exclude)
            {
                if (FilterExclude.ContainsKey(item) == false)
                    FilterExclude.Add(item.ToUpper(), item.ToUpper());
            }
        }

        /// <summary>
        /// 출력 가능 속성 여부 판단
        /// </summary>
        /// <param name="attribute">속성</param>
        /// <returns>결과 - True / False</returns>
        public bool IsAllowAttribute(string attribute)
        {
            string str = attribute.ToUpper();

            // 제외 항목 검사
            if (FilterExclude.ContainsKey(str) == true)
                return false;

            // 포함 항목 검사
            if (FilterInclude.ContainsKey(str) == true)
                return true;

            // 포함항목이 하나도 없는 경우 무조건 등록
            if (FilterInclude.Keys.Count == 0)
                return true;
            else // 포함항목이 하나라도 있는 경우라면 제외
                return false;
        }

        /// <summary>
        /// Make Attribute File for Import
        /// </summary>
        /// <param name="model">Model Info</param>
        /// <param name="path">Model Path</param>
        /// <param name="attribute_file">Attribute File</param>
        /// <param name="viz_file">VIZ File</param>
        /// <returns>결과 - True / False</returns>
        public bool MakeAttributeFile(Dictionary<string, ShxAttributeModelNode> model, string path, out string attribute_file, out string viz_file)
        {
            // 빠른 검색을 위한 데이터 새로 생성
            WriteOutput("빠른 검색을 위한 CACHE 데이터 생성...", OutputLogTypes.INFORMATION);
            Dictionary<string, ShxAttributeNode> att = new Dictionary<string, ShxAttributeNode>();

            // 전체 로딩된 속성을 MAP으로 생성
            for (int i = 0; i < AttributeList.Count; i++)
            {
                foreach (ShxAttributeNode item in AttributeList[i])
                {
                    //WriteOutput(string.Format("CACHE : {0} - {1}", item, item.NodePath), Color.Lime);
                    att.Add(item.NodePath, item);
                }
            }

            StringBuilder sb = new StringBuilder();
            int found = 0;

            if (AttributeList.Count != 0)
            {
                // 전체 노드를 대상으로 검색
                foreach (KeyValuePair<string, ShxAttributeModelNode> item in model)
                {
                    //WriteOutput(string.Format("노드 : {0}", item.NodePath), Color.Lime);

                    // 노드 경로로 비교 : item.Key (NodePath)
                    if (att.ContainsKey(item.Key) == true)
                    {
                        ShxAttributeNode fAtt = att[item.Key];

                        List<string> exclude = new List<string>();

                        foreach (KeyValuePair<string, string> kv in fAtt.Property)
                        {
                            if (IsAllowAttribute(kv.Key) == false)
                            {
                                exclude.Add(kv.Key);
                                //WriteOutput(string.Format("출력 불가 속성 : {0}", kv.Key), Color.Red);
                                continue;
                            }

                            //WriteOutput(string.Format("속성 추가 : {0}", kv.Key), Color.Lime);
                            sb.AppendLine(string.Format("{0}<<,>>{1}<<,>>{2}", item.Value.ID, kv.Key, kv.Value));
                            found++;
                        }

                        //WriteOutput(string.Format("출력 불가 속성 : {0}", string.Join(",", exclude.ToArray())), Color.Red);
                    }
                    else
                    {
                        //WriteOutput(string.Format("[결과] 미포함 노드 : {0}", item.Key), OutputLogTypes.WARNING);
                    }
                }
            }            

            // 찾은 결과가 없는 경우
            // 모델 노드 이름에 해당하는 속성 파일 기준으로 체크
            if(found == 0)
            {
                WriteOutput("모델/속성 파일 매핑 안됨", OutputLogTypes.ERROR);

                // KEY : NODE PATH
                // VAlUE : NODE Value Object (ID, NAME, NODEPATH)
                foreach (KeyValuePair<string, ShxAttributeModelNode> item in model)
                {
                    // MODEL
                    string nodepath = item.Key;
                    string node = item.Value.Name.ToUpper();

                    if(String.IsNullOrEmpty(AttributePath) == true && AttributeRootMap.ContainsKey(node) == true)
                    {
                        WriteOutput(string.Format("상대경로 속성파일 발견 : {0}", AttributeRootMap[node].AttributeFileName), OutputLogTypes.WARNING);

                        ShxAttributeNode root = null;
                        List<ShxAttributeNode> nodes = null;

                        WriteOutput(string.Format("상대경로 속성파일 분석 : {0}", AttributeRootMap[node].AttributeFileName), OutputLogTypes.WARNING);
                        ParseAttribute(AttributeRootMap[node].AttributeFileName, out root, out nodes, nodepath);

                        WriteOutput(string.Format("상대경로 속성파일 분석 결과 - 노드 : {0:N0} EA", nodes.Count), OutputLogTypes.WARNING);

                        Dictionary<string, ShxAttributeNode> relativeAtt = new Dictionary<string, ShxAttributeNode>();

                        WriteOutput(string.Format("상대경로 속성파일 CACHE 생성 - 속성 : {0:N0} EA", root.GetPropertyCount()), OutputLogTypes.INFORMATION);
                        // 전체 로딩된 속성을 MAP으로 생성
                        foreach (ShxAttributeNode attNode in nodes)
                        {
                            //WriteOutput(string.Format("CACHE : {0} - {1}", item, item.NodePath), Color.Lime);
                            relativeAtt.Add(attNode.NodePath, attNode);
                        }

                        // 전체 모델 재검색
                        int subfound = 0;
                        foreach (KeyValuePair<string, ShxAttributeModelNode> modelNode in model)
                        {
                            string relativeNodepath = modelNode.Key;
                            string relativeNode = modelNode.Value.Name.ToUpper();

                            if(relativeAtt.ContainsKey(relativeNodepath) == true)
                            {
                                ShxAttributeNode rAtt = relativeAtt[relativeNodepath];

                                foreach (KeyValuePair<string, string> rKV in rAtt.Property)
                                {
                                    if (IsAllowAttribute(rKV.Key) == true)
                                    {
                                        sb.AppendLine(string.Format("{0}<<,>>{1}<<,>>{2}", modelNode.Value.ID, rKV.Key, rKV.Value));
                                        found++;
                                        subfound++;
                                    }
                                }
                            }
                        }
                        WriteOutput(string.Format("상대경로 기반 속성 연계 결과 - 속성 : {0:N0} EA", subfound), OutputLogTypes.INFORMATION);
                    }
                    else if(String.IsNullOrEmpty(AttributePath) == false)
                    {
                        string attfile = string.Format("{0}\\{1}.att", AttributePath, node);

                        if (System.IO.File.Exists(attfile) == false) continue;

                        WriteOutput(string.Format("상대경로 속성파일 발견 : {0}.att", node), OutputLogTypes.WARNING);

                        ShxAttributeNode root = null;
                        List<ShxAttributeNode> nodes = null;

                        WriteOutput(string.Format("상대경로 속성파일 분석 : {0}.att", node), OutputLogTypes.WARNING);
                        ParseAttribute(attfile, out root, out nodes, nodepath);

                        WriteOutput(string.Format("상대경로 속성파일 분석 결과 - 노드 : {0:N0} EA", nodes.Count), OutputLogTypes.WARNING);

                        Dictionary<string, ShxAttributeNode> relativeAtt = new Dictionary<string, ShxAttributeNode>();

                        WriteOutput(string.Format("상대경로 속성파일 CACHE 생성 - 속성 : {0:N0} EA", root.GetPropertyCount()), OutputLogTypes.INFORMATION);
                        // 전체 로딩된 속성을 MAP으로 생성
                        foreach (ShxAttributeNode attNode in nodes)
                        {
                            //WriteOutput(string.Format("CACHE : {0} - {1}", item, item.NodePath), Color.Lime);
                            relativeAtt.Add(attNode.NodePath, attNode);
                        }

                        // 전체 모델 재검색
                        int subfound = 0;
                        foreach (KeyValuePair<string, ShxAttributeModelNode> modelNode in model)
                        {
                            string relativeNodepath = modelNode.Key;
                            string relativeNode = modelNode.Value.Name.ToUpper();

                            if (relativeAtt.ContainsKey(relativeNodepath) == true)
                            {
                                ShxAttributeNode rAtt = relativeAtt[relativeNodepath];

                                foreach (KeyValuePair<string, string> rKV in rAtt.Property)
                                {
                                    if (IsAllowAttribute(rKV.Key) == true)
                                    {
                                        sb.AppendLine(string.Format("{0}<<,>>{1}<<,>>{2}", modelNode.Value.ID, rKV.Key, rKV.Value));
                                        found++;
                                        subfound++;
                                    }
                                }
                            }
                        }
                        WriteOutput(string.Format("상대경로 기반 속성 연계 결과 - 속성 : {0:N0} EA", subfound), OutputLogTypes.INFORMATION);
                    }
                }
            }

            attribute_file = string.Format("{0}\\{1}.sha", System.IO.Path.GetDirectoryName(path), System.IO.Path.GetFileNameWithoutExtension(path));
            viz_file = string.Format("{0}\\{1}_ATTRIBUTE.viz", System.IO.Path.GetDirectoryName(path), System.IO.Path.GetFileNameWithoutExtension(path));

            if (found != 0)
            {
                WriteOutput(string.Format("속성 파일 생성 : {0}", attribute_file), OutputLogTypes.INFORMATION);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(attribute_file, false);
                sw.WriteLine(sb.ToString());
                sw.Close();

                return true;
            }
            else
            {
                return false;
            }
        }

        private void WriteOutput(string message, OutputLogTypes logtype)
        {
            if (OutputLogEvent == null) return;

            OutputLogEvent(this, new OutputLogEventArgs(message, logtype));
        }
    }

    /// <summary>
    /// Output Log Event Handler
    /// </summary>
    /// <param name="sender">sender</param>
    /// <param name="e">Event Argument</param>
    public delegate void OutputLogEventHandler(object sender, OutputLogEventArgs e);

    /// <summary>
    /// Output Log Event Args.
    /// </summary>
    public class OutputLogEventArgs : EventArgs
    {
        /// <summary>
        /// Output Log Type
        /// </summary>
        public OutputLogTypes LogType { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Log Color
        /// </summary>
        public Color LogColor { get; set; }

        /// <summary>
        /// Construction
        /// </summary>
        public OutputLogEventArgs()
        {
        }

        /// <summary>
        /// Construction
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="logtype">Output Log Type</param>
        public OutputLogEventArgs(string message, OutputLogTypes logtype)
        {
            Message = message;
            LogType = logtype;

            switch (LogType)
            {
                case OutputLogTypes.INFORMATION:
                    LogColor = Color.Lime;
                    break;
                case OutputLogTypes.WARNING:
                    LogColor = Color.Yellow;
                    break;
                case OutputLogTypes.ERROR:
                    LogColor = Color.Red;
                    break;
                default:
                    break;
            }
        }
    }

    /// <summary>
    /// OUTPUT LOG TYPES
    /// </summary>
    public enum OutputLogTypes
    {
        /// <summary>
        /// INFORMATION
        /// </summary>
        INFORMATION = 0,
        /// <summary>
        /// WARNING
        /// </summary>
        WARNING = 1,
        /// <summary>
        /// ERROR
        /// </summary>
        ERROR = 2
    }
}
