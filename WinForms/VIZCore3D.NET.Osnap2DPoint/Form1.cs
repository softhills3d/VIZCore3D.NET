using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VIZCore3D.NET.Data;
using VIZCore3D.NET.Event;

namespace VIZCore3D.NET.Osnap2DPoint
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// VIZCore3D.NET
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        public Form1()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            // Construction
            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(vizcore3d);

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            // 라이선스 서버 주소 입력
            vizcore3d.License.LicenseServer("127.0.0.1", 8901);

            // Osnap 선택 포인트 가져오기
            vizcore3d.GeometryUtility.OnOsnapPickingItem += GeometryUtility_OnOsnapPickingItem;
        }

        /// <summary>
        /// 선택한 Onsap 측정 포인트를 가져옵니다.
        /// https://softhills.net/SHDC/VIZCore3D.NET/Help/html/E_VIZCore3D_NET_Manager_GeometryUtilityManager_OnOsnapPickingItem.htm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeometryUtility_OnOsnapPickingItem(object sender, EventManager.OsnapPickingItemEventArgs e)
        {
            // 화면 기준 2D 포인트 좌표 변경
            Vertex3D point2D = vizcore3d.View.WorldToScreen(e.Point, true);

            // 노트로 표기
            vizcore3d.Review.Note.AddNoteSurface($"{point2D.X}, {point2D.Y}", e.Point);
        }

        private void btnShowOsnap_Click(object sender, EventArgs e)
        {
            // 카메라 회전
            // https://softhills.net/SHDC/VIZCore3D.NET/Help/html/M_VIZCore3D_NET_Manager_ViewManager_MoveCamera_2.htm
            vizcore3d.View.MoveCamera(VIZCore3D.NET.Data.CameraDirection.Z_PLUS);

            // 카메라 회전 고정
            // https://softhills.net/SHDC/VIZCore3D.NET/Help/html/P_VIZCore3D_NET_Manager_ScreenAxisRotationManager_LockZAxis.htm
            vizcore3d.View.ScreenAxisRotation.LockZAxis = true;

            // 화면 이동 모드 변경
            // https://softhills.net/SHDC/VIZCore3D.NET/Help/html/P_VIZCore3D_NET_Manager_ViewManager_Navigation.htm
            vizcore3d.View.Navigation = Data.NavigationModes.PAN;

            // 선택된 개체 가져오기
            // https://softhills.net/SHDC/VIZCore3D.NET/Help/html/M_VIZCore3D_NET_Manager_Object3DManager_FromFilter.htm
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(Data.Object3dFilter.SELECTED_TOP);

            // 개체 선택 방식
            if (items.Count == 0)
            {
                // 개체 선택 Osnap 표시
                // https://softhills.net/SHDC/VIZCore3D.NET/Help/html/M_VIZCore3D_NET_Manager_GeometryUtilityManager_ShowOsnap.htm
                vizcore3d.GeometryUtility.ShowOsnap(
                    false   // 면 표시 여부
                    , true  // 점 표시 여부
                    , false // 라인 표시 여부
                    , false // 원 표시 여부
                    );
            }
            // 개체 지정 방식
            else
            {
                // 개체 지정 Osnap 표시
                // https://softhills.net/SHDC/VIZCore3D.NET/Help/html/M_VIZCore3D_NET_Manager_GeometryUtilityManager_ShowOsnap_2.htm
                vizcore3d.GeometryUtility.ShowOsnap(
                    items[0].Index  // 개체 인덱스
                    , false         // 면 표시 여부
                    , true          // 점 표시 여부
                    , false         // 라인 표시 여부
                    , false         // 원 표시 여부
                    );
            }
        }
    }
}
