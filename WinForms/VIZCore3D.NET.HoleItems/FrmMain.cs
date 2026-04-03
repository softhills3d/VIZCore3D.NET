using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIZCore3D.NET.HoleItems
{
    public partial class FrmMain : Form
    {
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        public FrmMain()
        {
            InitializeComponent();

            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
            splitContainer1.Panel2.Controls.Add(vizcore3d);
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.LicenseResults result =
                vizcore3d.License.LicenseServer("127.0.0.1", 8901);

            if (result != VIZCore3D.NET.Data.LicenseResults.SUCCESS) return;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            vizcore3d.Model.OpenFileDialog();
        }

        private void btnGetHoleItems_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> selection = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.SELECTED_TOP);
            if (selection.Count == 0) return;

            List<VIZCore3D.NET.Data.NodeHoleItem> items = vizcore3d.GeometryUtility.GetNodeHoleInfo(selection[0].Index);
            
            lvItems.Items.Clear();

            foreach (VIZCore3D.NET.Data.NodeHoleItem item in items)
            {
                ListViewItem lvi = new ListViewItem(new string[] { item.NodeIndex.ToString(), item.HoleType.ToString(), item.Center.ToString() });
                lvItems.Items.Add(lvi);
            }

            // 기존 프리미티브 초기화
            vizcore3d.Primitive.Clear();

            // 루트 노드 생성 (Yellow = 색상 인덱스 4)
            VIZCore3D.NET.Manager.PrimitiveObject rootNode =
                vizcore3d.Primitive.AddNode("HoleMarkers", 4);

            // 각 홀 항목을 순회하며 시각화
            for (int i = 0; i < items.Count; i++)
            {
                VIZCore3D.NET.Data.NodeHoleItem item = items[i];

                // 홀 타입별 색상 인덱스 구분
                // (rev2bst.config.rev 파일 기준: 4=Yellow, 7=Blue, 11=Pink, 2=Red, 9=Green)
                int colorIndex = GetHoleColorIndex(item.HoleType);

                // 홀별 자식 노드 생성
                string nodeName = string.Format("Hole_{0}_{1}", i + 1, item.HoleType);
                VIZCore3D.NET.Manager.PrimitiveObject holeNode =
                    rootNode.AddNode(nodeName, colorIndex);

                // ── 방법 1: 홀 축 방향을 따라 실린더로 시각화 ──
                // ThicknessCenterFrom → ThicknessCenterTo 방향으로 실린더 생성
                if (item.ThicknessCenterFrom != null && item.ThicknessCenterTo != null)
                {
                    VIZCore3D.NET.Manager.PrimitiveCylinder cylinder =
                        new VIZCore3D.NET.Manager.PrimitiveCylinder();

                    cylinder.Set2Point(
                        item.ThicknessCenterFrom.ToVertex3D(),   // 시작점 (Vertex3D)
                        item.ThicknessCenterTo.ToVertex3D(),     // 끝점 (Vertex3D)
                        item.Radius                 // 홀 반지름 그대로 사용
                    );

                    holeNode.AddPrimitive(cylinder);
                }
                else
                {
                    // ThicknessCenter가 없는 경우: Center + AxisZ 를 이용해 짧은 실린더 생성
                    // AxisZ 방향으로 반지름 * 2 길이의 마커 실린더 표시
                    VIZCore3D.NET.Data.Vector3D center = item.Center;
                    VIZCore3D.NET.Data.Vector3D axisZ = item.AxisZ;

                    // 마커 길이 = 반지름 * 2 (가시성 확보)
                    float markerLength = item.Radius * 2.0f;

                    // AxisZ 방향 단위벡터로 시작/끝 계산
                    VIZCore3D.NET.Data.Vertex3D from = new VIZCore3D.NET.Data.Vertex3D(
                        center.X - axisZ.X * markerLength,
                        center.Y - axisZ.Y * markerLength,
                        center.Z - axisZ.Z * markerLength
                    );
                    VIZCore3D.NET.Data.Vertex3D to = new VIZCore3D.NET.Data.Vertex3D(
                        center.X + axisZ.X * markerLength,
                        center.Y + axisZ.Y * markerLength,
                        center.Z + axisZ.Z * markerLength
                    );

                    VIZCore3D.NET.Manager.PrimitiveCylinder cylinder =
                        new VIZCore3D.NET.Manager.PrimitiveCylinder();

                    cylinder.Set2Point(from, to, item.Radius);
                    holeNode.AddPrimitive(cylinder);
                }
            }

            // 프리미티브 모델을 VIZCore3D.NET에 적용 (addMode: true = 기존 모델에 추가)
            vizcore3d.Primitive.OpenModel("HoleVisualization", true);
        }

        private int GetHoleColorIndex(VIZCore3D.NET.Data.NodeHoleItem.NodeHoleType holeType)
        {
            // 홀 타입별 색상 분류 (필요에 따라 조정)
            switch (holeType)
            {
                case VIZCore3D.NET.Data.NodeHoleItem.NodeHoleType.CIRCLE: return 7;  // Blue
                case VIZCore3D.NET.Data.NodeHoleItem.NodeHoleType.SLOT_HOLE: return 4;  // Yellow
                default: return 11; // Pink
            }
        }

        /// <summary>
        /// 홀 시각화 프리미티브를 제거합니다.
        /// </summary>
        private void ClearHoleVisualization()
        {
            vizcore3d.Primitive.Clear();
        }
    }
}
