using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VIZCore3D.NET.Event;

namespace VIZCore3D.NET.ShortutsAreaSelectionBox
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// VIZCore3D.NET 컨트롤 인스턴스
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        public Form1()
        {
            InitializeComponent();

            // VIZCore3D.NET 초기화
            VIZCore3D.NET.ModuleInitializer.Run();

            // 컨트롤 생성 및 패널에 추가
            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            panel1.Controls.Add(vizcore3d);

            // 초기화 및 이벤트 연결
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            // 라이선스 서버 설정
            vizcore3d.License.LicenseServer("127.0.0.1", 8901);

            // 공간 선택 이벤트 설정
            vizcore3d.View.OnAreaSelectionBeginEvent += View_OnAreaSelectionBeginEvent;
            vizcore3d.View.OnAreaSelectionEndEvent += View_OnAreaSelectionEndEvent;

            // 기존 공간 선택 단축키 설정 제거
            vizcore3d.Shortcuts.Disable(Data.ShortcutFunctions.CONTROL_SELECTION_BOX);

            // 공간 선택 신규 단축키 설정
            vizcore3d.Shortcuts.Update(
                Data.ShortcutFunctions.CONTROL_SELECTION_BOX
                , Keys.W
                , true
                , true
                , false
                );
        }

        private void View_OnAreaSelectionBeginEvent(object sender, ref EventManager.ViewAreaSelectionBeginEventArgs e)
        {
            // 커스텀 텍스트 적용 
            // 단일 언어 사용 시
            e.CustomText = "선택 상자 이벤트 커스텀 텍스트 적용";

            //// 다국어 적용 시
            //LanguageKind language = vizcore3d.Language.GetLanguage();
            //switch (language)
            //{
            //    case LanguageKind.UNKNOWN:
            //        e.CustomText = "Drag Selection Box Activated";
            //        break;

            //    case LanguageKind.KOREAN:
            //        e.CustomText = "Drag 선택 상자 이벤트 커스텀 텍스트 적용";
            //        break;

            //    case LanguageKind.ENGLISH:
            //        e.CustomText = "Apply Drag Selection Box Custom Text";
            //        break;

            //    case LanguageKind.CHINESE:
            //        // Apply Drag Selection Box Custom Text
            //        e.CustomText = "应用拖动选择框自定义文本";  
            //        break;

            //    case LanguageKind.JAPANESE:
            //        // Apply Drag Selection Box Custom Text
            //        e.CustomText = "ドラッグ選択ボックスのカスタムテキストを適用";  
            //        break;

            //    default:
            //        e.CustomText = "Drag Selection Box Activated";
            //        break;
            //}
        }

        private void View_OnAreaSelectionEndEvent(object sender, EventManager.ViewAreaSelectionEndEventArgs e)
        {
            // 시작점과 끝점 좌표 출력
            System.Diagnostics.Debug.WriteLine(string.Format("Area Selection End : {0} / {1} | {2} / {3}", e.BeginPoint.X, e.BeginPoint.Y, e.EndPoint.X, e.EndPoint.Y));
            //MessageBox.Show($"Begin Point == {e.BeginPoint}\nEnd Point == {e.EndPoint}");
        }
    }
}
