using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VIZCore3D.NET.Data;

namespace VIZCore3D.NET.SectionCoordinate
{
    public partial class FrmMain : Form
    {
        public VIZCore3D.NET.VIZCore3DControl vizcore3d { get; set; }

        public VIZCore3D.NET.Data.Section Section { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;

            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;

            splitContainer1.Panel2.Controls.Add(vizcore3d);
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.LicenseResults result = 
                vizcore3d.License.LicenseServer("127.0.0.1", 8901);

            if (result != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            { 
                MessageBox.Show(string.Format("License Error Code: {0}", result), "License", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenModel_Click(object sender, EventArgs e)
        {
            vizcore3d.Model.OpenFileDialog();
        }

        private void btnAddSectionBox_Click(object sender, EventArgs e)
        {
            Section = vizcore3d.Section.AddBox(false);
        }

        private void btnAddSectionBox_Click_1(object sender, EventArgs e)
        {
            vizcore3d.Section.AddBox(false);
        }

        private void btnSubscribeEvent_Click(object sender, EventArgs e)
        {
            // 전제조건 : 모델이 열려 있어야 단면을 만들고 마우스로 이동할 수 있음.
            // 모델을 여기서 자동으로 열지 않는다. 사용자가 원하는 모델을 먼저 연다.
            if (vizcore3d.Model.IsOpen() == false)
            {
                vizcore3d.View.Message.Show(VIZCore3D.NET.Data.MessageId.ID_01, "모델을 먼저 여세요.", 20, 20);
                return;
            }

            vizcore3d.Section.OnSectionEvent -= Section_ShowMovingPlaneCoordinate;
            vizcore3d.Section.OnSectionEvent += Section_ShowMovingPlaneCoordinate;
            vizcore3d.View.Message.Hide(VIZCore3D.NET.Data.MessageId.ID_01);
            vizcore3d.View.Message.Hide(VIZCore3D.NET.Data.MessageId.ID_02);

            vizcore3d.View.Message.Show(VIZCore3D.NET.Data.MessageId.ID_01, 
                "단면 또는 단면상자를 만든 뒤 마우스로 잡고 이동해 보세요.",
                20, 20);
        }

        private void Section_ShowMovingPlaneCoordinate(object sender, VIZCore3D.NET.Event.EventManager.SectionEventArgs e)
        {
            Console.WriteLine($"jjamlog, eventType: {e.EventType}");

            if (e.EventType != Manager.SectionManager.EventTypes.TRANSFORM
                && e.EventType != Manager.SectionManager.EventTypes.RESIZED) return;

            VIZCore3D.NET.Data.Vertex3D center = e.Plane.Center;

            string text = string.Format("X={0:F2}\nY={1:F2}\nZ={2:F2}",
                center.X,
                center.Y,
                center.Z);

            // 형상을 가리지 않는 위치를 골라 직접 표시한다. 위치와 스타일은 전적으로 사용자가 정한다.
            vizcore3d.View.Message.Show(VIZCore3D.NET.Data.MessageId.ID_02, text, 20, 60,
                VIZCore3D.NET.Data.FontSize.Size_14_Bold, Color.Black);

            // 이동을 마쳤을 경우, 좌표 텍스트 제거.
            if (e.EventType == VIZCore3D.NET.Manager.SectionManager.EventTypes.RESIZED)
            {
                vizcore3d.View.Message.Hide(VIZCore3D.NET.Data.MessageId.ID_02);
            }
        }
    }
}
