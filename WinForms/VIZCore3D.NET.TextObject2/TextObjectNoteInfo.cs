using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using VIZCore3D.NET.Data;
using VIZCore3D.NET.TextObject2.Properties;
using static System.Net.Mime.MediaTypeNames;
using static VIZCore3D.NET.Data.NoteItem;

namespace VIZCore3D.NET.TextObject2
{
    // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    // !!! VIZCore3D.NET V.2.8.26.410 이상에서 정상 동작 합니다 !!!
    // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public class TextObjectNoteInfo
    {
        public VIZCore3D.NET.VIZCore3DControl Vizcore3d;

        // TextObject 노트의 ID
        public int NoteId = -1;

        public string Title;
        public Vertex3D Pos;
        public Vertex3D Normal;
        public Vertex3D TextDir;
        public Vertex3D TextUp;
        public float CharHeight;    // 한 글자의 높이(mm)
        public float TextWidth;     // 텍스트의 Width
        public float TextHeight;    // 텍스트의 Height

        /// <summary>
        /// NoteItem 으로부터 TextObject 노트 정보 추출하여 객체 생성
        /// 실패시 null 리턴
        /// </summary>
        public static TextObjectNoteInfo FromNoteItem(NoteItem noteItem, VIZCore3D.NET.VIZCore3DControl vizcore3d)
        {
            Vertex3D pos = null;
            Vertex3D normal = null;
            Vertex3D textDir = null;
            Vertex3D textUp = null;
            float charHeight = 0.0f;
            float textWidth = 0.0f;
            float textHeight = 0.0f;

            if (noteItem == null) return null;
            if (noteItem.Kind != NoteItem.NoteKind.TEXT_OBJECT) return null;

            // 현재 note 들을 임시 JSON 파일로 export 후, 그 JSON 파일을 읽어서, 거기에 있는 값들을 추출
            {
                string tempFilePath = GetRandomFilePathWithJsonExtOnTempPath();
                bool result = vizcore3d.Review.SaveAsJson(tempFilePath);

                if (result == false)
                {
                    return null;
                }

                string review = System.IO.File.ReadAllText(tempFilePath);

                // Temp 파일 삭제
                System.IO.File.Delete(tempFilePath);

                JToken root = JToken.Parse(review);     // JObject 또는 JArray
                JArray noteArray = root.SelectToken("note") as JArray;

                foreach (JObject item in noteArray)
                {
                    int id = item.Value<int>("id");
                    if (id != noteItem.ID) continue;

                    //
                    charHeight = item.Value<float>("surface_height");

                    //
                    textWidth = item.Value<float>("text_width");
                    textHeight = item.Value<float>("text_height");

                    //
                    float rotate = 0.0f;
                    JObject transform = item.Value<JObject>("transform");
                    if (transform != null)
                    {
                        rotate = transform.Value<float>("rotate") * -1.0f;
                    }

                    JObject surfaceNormal = item.Value<JObject>("surface_normal");
                    normal = new Vertex3D(surfaceNormal.Value<float>("x"), surfaceNormal.Value<float>("y"), surfaceNormal.Value<float>("z"));

                    JObject surfaceDirection = item.Value<JObject>("surface_direction");
                    textDir = new Vertex3D(surfaceDirection.Value<float>("x"), surfaceDirection.Value<float>("y"), surfaceDirection.Value<float>("z"));

                    // 주의! "surface_up" 사용금지!
                    // 대신 "surface_normal" 과 "surface_direction" 을 외적해서 textUp 을 계산해서 사용할것!
                    textUp = normal.Cross(textDir);
                    textUp.Normalize();

                    pos = new Vertex3D(noteItem.Positions[3], noteItem.Positions[4], noteItem.Positions[5]);

                    // 회전 전 방향벡터로 pos 에 회전값 적용
                    {
                        Vertex3D center = pos + (textDir * (textWidth / 2.0f)) + (textUp * (textHeight / 2.0f));
                        
                        // pos 를 원점 기준으로 이동
                        Vertex3D posOnOrigin = pos - center;
                        
                        // 원점에서의 회전 적용
                        posOnOrigin = RotateWithRodriguesRotationFormula(normal, posOnOrigin, rotate);

                        // 기존 기준점으로 이동
                        pos = posOnOrigin + center;
                    }

                    // textDir, textUp 에도 회전값 적용
                    textDir = RotateWithRodriguesRotationFormula(normal, textDir, rotate);
                    textUp = RotateWithRodriguesRotationFormula(normal, textUp, rotate);

                    break;
                }
            }

            if (normal == null || textDir == null || textUp == null)
            {
                return null;
            }

            return new TextObjectNoteInfo()
            {
                Vizcore3d = vizcore3d,
                NoteId = noteItem.ID,

                Title = noteItem.Title,
                Pos = pos,
                Normal = normal,
                TextDir = textDir,
                TextUp = textUp,
                CharHeight = charHeight,
                TextWidth = textWidth,
                TextHeight = textHeight,
            };
        }

        public void RedrawTextObjectNote()
        {
            if (NoteId < 0) return;

            Vizcore3d.BeginUpdate();

            // 기존 TextObject 노트 삭제
            Vizcore3d.Review.Note.Delete(NoteId);

            // 다시 TextObject 추가
            Vizcore3d.Review.Note.SetNoteTextObjectHeightSize(CharHeight, FontSizeKind.SIZE72);
            NoteId = Vizcore3d.Review.Note.AddSurfaceTextObjectNote(Title, "", Pos, TextDir, TextUp);

            Vizcore3d.EndUpdate();
        }

        /// <summary>
        /// Normal 방향으로 이동
        /// </summary>
        /// <param name="delta"></param>
        public void MoveAlongNormal(float delta)
        {
            if (NoteId < 0) return;

            Pos += (Normal * delta);

            RedrawTextObjectNote();
        }

        /// <summary>
        /// TextDir 방향으로 이동
        /// </summary>
        /// <param name="delta"></param>
        public void MoveAlongTextDir(float delta)
        {
            if (NoteId < 0) return;

            Pos += (TextDir * delta);

            RedrawTextObjectNote();
        }

        /// <summary>
        /// TextUp 방향으로 이동
        /// </summary>
        /// <param name="delta"></param>
        public void MoveAlongTextUp(float delta)
        {
            if (NoteId < 0) return;

            Pos += (TextUp * delta);

            RedrawTextObjectNote();
        }

        /// <summary>
        /// Normal 을 축으로 회전
        /// </summary>
        /// <param name="angle"></param>
        public void RotateWithNormal(float angle)
        {
            if (NoteId < 0) return;

            // 회전 전 텍스트 중심점 계산 (좌하단 Pos 기준)
            Vertex3D center = Pos + (TextDir * (TextWidth / 2.0f)) + (TextUp * (TextHeight / 2.0f));

            // 방향 벡터 회전
            TextDir = RotateWithRodriguesRotationFormula(Normal, TextDir, angle);
            TextDir.Normalize();

            TextUp = RotateWithRodriguesRotationFormula(Normal, TextUp, angle);
            TextUp.Normalize();

            // 회전된 방향 벡터로 중심점에서 좌하단 위치 역산
            Pos = center - (TextDir * (TextWidth / 2.0f)) - (TextUp * (TextHeight / 2.0f));

            RedrawTextObjectNote();
        }

        /// <summary>
        /// TextDir 을 축으로 회전
        /// </summary>
        /// <param name="angle"></param>
        public void RotateWithTextDir(float angle)
        {
            if (NoteId < 0) return;

            // 회전 전 텍스트 중심점 계산 (좌하단 Pos 기준)
            Vertex3D center = Pos + (TextDir * (TextWidth / 2.0f)) + (TextUp * (TextHeight / 2.0f));

            // 방향 벡터 회전
            Normal = RotateWithRodriguesRotationFormula(TextDir, Normal, angle);
            Normal.Normalize();

            TextUp = RotateWithRodriguesRotationFormula(TextDir, TextUp, angle);
            TextUp.Normalize();

            // 회전된 방향 벡터로 중심점에서 좌하단 위치 역산
            Pos = center - (TextDir * (TextWidth / 2.0f)) - (TextUp * (TextHeight / 2.0f));

            RedrawTextObjectNote();
        }

        /// <summary>
        /// TextUp 을 축으로 회전
        /// </summary>
        /// <param name="angle"></param>
        public void RotateWithTextUp(float angle)
        {
            if (NoteId < 0) return;

            // 회전 전 텍스트 중심점 계산 (좌하단 Pos 기준)
            Vertex3D center = Pos + (TextDir * (TextWidth / 2.0f)) + (TextUp * (TextHeight / 2.0f));

            // 방향 벡터 회전
            Normal = RotateWithRodriguesRotationFormula(TextUp, Normal, angle);
            Normal.Normalize();

            TextDir = RotateWithRodriguesRotationFormula(TextUp, TextDir, angle);
            TextDir.Normalize();

            // 회전된 방향 벡터로 중심점에서 좌하단 위치 역산
            Pos = center - (TextDir * (TextWidth / 2.0f)) - (TextUp * (TextHeight / 2.0f));

            RedrawTextObjectNote();
        }

        public override string ToString()
        {
            return string.Format(
                "Pos({0:F3}, {1:F3}, {2:F3}) / Normal({3:F3}, {4:F3}, {5:F3}) / TextDir({6:F3}, {7:F3}, {8:F3}) / TextUp({9:F3}, {10:F3}, {11:F3}) / CharHeight({12:F3})",
                Pos?.X ?? 0, Pos?.Y ?? 0, Pos?.Z ?? 0,
                Normal?.X ?? 0, Normal?.Y ?? 0, Normal?.Z ?? 0,
                TextDir?.X ?? 0, TextDir?.Y ?? 0, TextDir?.Z ?? 0,
                TextUp?.X ?? 0, TextUp?.Y ?? 0, TextUp?.Z ?? 0,
                CharHeight
            );
        }

        /// <summary>
        /// .json 확장자를 가지는 랜덤 파일명 full path 리턴
        /// </summary>
        /// <returns></returns>
        public static string GetRandomFilePathWithJsonExtOnTempPath()
        {
            string tempDirectory = Path.GetTempPath();
            string fileNameWithJsonExt = Path.GetRandomFileName() + ".json";
            string fullPath = Path.Combine(tempDirectory, fileNameWithJsonExt);

            return fullPath;
        }

        /// <summary>
        /// 굴림체 폰트로 텍스트를 렌더링하여 측정된 크기의 가로/세로 비율(width/height)을 리턴
        /// </summary>
        public static float MeasureTextWidthHeightRatio(string text)
        {
            if (string.IsNullOrEmpty(text)) return 1.0f;

            using (Bitmap bmp = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(bmp))
            using (Font font = new Font("굴림", 72f, FontStyle.Regular, GraphicsUnit.Point))
            {
                SizeF size = g.MeasureString(text, font);
                if (size.Height <= 0) return 1.0f;
                return size.Width / size.Height;
            }
        }

        /// <summary>
        /// 축-각 회전 공식 (Rodrigues' rotation formula)
        /// </summary>
        /// <param name="n">회전 축</param>
        /// <param name="u">회전시킬 벡터</param>
        /// <param name="angle">회전각(오일러 각)</param>
        /// <returns>회전된 벡터</returns>
        public static Vertex3D RotateWithRodriguesRotationFormula(Vertex3D n, Vertex3D u, float angle)
        {
            n.Normalize();
            double radian = DegreeToRadian(angle);

            Vertex3D uPrime = u * (float)Math.Cos(radian) + n * (float)(1 - Math.Cos(radian)) * (u.Dot(n)) + n.Cross(u) * (float)Math.Sin(radian);
            return uPrime;
        }

        /// <summary>
        /// 오일러 각도를 라디안으로 변환
        /// </summary>
        public static double DegreeToRadian(double angle)
        {
            return angle * (Math.PI / 180.0);
        }
    }
}
