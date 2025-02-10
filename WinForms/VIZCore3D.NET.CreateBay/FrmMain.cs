using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.PlacementStatus
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// VIZCore3D.NET
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        /// <summary>
        /// 영역 저장 [ Bay Title 입력 하기 위함 ]
        /// </summary>
        private Dictionary<string, Data.BoundBox3D> SpaceManager { get; set; }

        public FrmMain()
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

            SpaceManager = new Dictionary<string, Data.BoundBox3D>();
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            // 라이선스 서버 주소 입력
            vizcore3d.License.LicenseServer("127.0.0.1", 8901);
        } 

        private void MakeDashboard()
        {
            // 베이를 생성 할  행 / 열 수치
            float contentsColumn = Convert.ToSingle(txtContentsColumn.Text); // 4.0f;
            float contentsRow = Convert.ToSingle(txtContentsRow.Text); // 5.0f;

            // 베이 생성 간격 ( 행 / 열 )
            float spacing = Convert.ToSingle(txtBaySpacing.Text); // 1000.0f;

            // 베이 크기
            float bayWidth = Convert.ToSingle(txtBayWidth.Text); // 15000.0f;
            float bayHeight = Convert.ToSingle(txtBayHeight.Text); // 15000.0f;

            vizcore3d.Model.Close();
            SpaceManager.Clear();

            // 루트 노드 생성
            VIZCore3D.NET.Manager.PrimitiveObject root = vizcore3d.Primitive.AddNode("Bays");

            // 행 / 열 기준으로 생성
            int ID = 1;
            for (int i = 0; i < contentsRow; i++)
            {
                for (int j = 0; j < contentsColumn; j++)
                {
                    {
                        VIZCore3D.NET.Manager.PrimitiveObject modelItem = root.AddNode(string.Format("Bay_{0:D2}", ID), 10);

                        // Primitive Box 생성
                        VIZCore3D.NET.Manager.PrimitiveBox bayBox = new VIZCore3D.NET.Manager.PrimitiveBox();

                        // 생성 위치 지정 [ 간격 설정 ]
                        VIZCore3D.NET.Data.Vertex3D min = new VIZCore3D.NET.Data.Vertex3D(
                            j * (bayWidth + spacing)
                            , -i * (bayHeight + spacing)
                            , -500
                            );

                        VIZCore3D.NET.Data.Vertex3D max = new VIZCore3D.NET.Data.Vertex3D(
                            j * (bayWidth + spacing) + bayWidth
                            , -i * (bayHeight + spacing) - bayHeight
                            , 0
                            );

                        // 영역 저장
                        VIZCore3D.NET.Data.BoundBox3D bayBoundBox = new VIZCore3D.NET.Data.BoundBox3D(min, max);
                        SpaceManager.Add(string.Format("Bay_{0:D2}", ID), bayBoundBox);
                        bayBox.SetMinMaxPoints(bayBoundBox);
                        modelItem.AddPrimitive(bayBox);
                    }

                    ID++;
                }
            }
            vizcore3d.TextDrawing.Clear();

            // 글꼴 설정 값
            int fontHeight = 1000;
            float fontSize = 100; 

            // 각 Bay 마다 Title 추가 [ 영역 저장된 이름을 표기 ] ex) Bay_01..Bay_02..Bay_03..
            foreach (KeyValuePair<string, Data.BoundBox3D> item in SpaceManager)
            {
                if (item.Key.Contains("Bay_") == false) continue;

                VIZCore3D.NET.Data.Vertex3D center = new VIZCore3D.NET.Data.Vertex3D();
                center.X = item.Value.MinX;
                center.Y = item.Value.MinY + item.Value.LengthY;
                center.Z = item.Value.MaxZ;

                vizcore3d.TextDrawing.Add(
                    center
                    , new VIZCore3D.NET.Data.Vector3D(1, 0, 0) /* X+ 방향으로 텍스트가 표시 */
                    , new VIZCore3D.NET.Data.Vector3D(0, 1, 0) /* 텍스트의 위쪽 방향 : Z+에서 볼때, Y+가 위쪽 임. */
                    , fontHeight
                    , fontSize
                    , Color.Black
                    , item.Key
                    );
            }
            
            // Primitive를 생성 하기 위한 공백 모델 생성 [ "BAY_BLOCK" 명칭 지정 ]
            vizcore3d.Primitive.OpenModel("BAY_BLOCK");

            // 화면 설정 변경
            vizcore3d.View.MoveCamera(VIZCore3D.NET.Data.CameraDirection.Z_PLUS);
            vizcore3d.View.Navigation = VIZCore3D.NET.Data.NavigationModes.PAN;
            vizcore3d.View.SetRenderMode(VIZCore3D.NET.Data.RenderModes.SMOOTH_EDGE);
            vizcore3d.View.FitToView();
        }
        private void btnMake_Click(object sender, EventArgs e)
        {
            MakeDashboard();
            vizcore3d.View.SilhouetteEdge = true;
        }
    }
}
