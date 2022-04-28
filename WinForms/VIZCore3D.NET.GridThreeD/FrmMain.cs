using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.GridThreeD
{
    public partial class FrmMain : Form
    {
        // ================================================
        // Attribute & Property
        // ================================================
        /// <summary>
        /// VIZCore3D.NET
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3dMain;
        private VIZCore3D.NET.VIZCore3DControl vizcore3dDisassembly;
        private VIZCore3D.NET.VIZCore3DControl vizcore3dGrid;
        private VIZCore3D.NET.VIZCore3DControl vizcore3dView;

        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            // Construction
            {
                vizcore3dMain = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dMain.Dock = DockStyle.Fill;
                splitContainer3.Panel1.Controls.Add(vizcore3dMain);
            }

            {
                vizcore3dDisassembly = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dDisassembly.Dock = DockStyle.Fill;
                splitContainer3.Panel2.Controls.Add(vizcore3dDisassembly);
            }

            {
                vizcore3dGrid = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dGrid.Dock = DockStyle.Fill;
                splitContainer4.Panel1.Controls.Add(vizcore3dGrid);
            }

            {
                vizcore3dView = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dView.Dock = DockStyle.Fill;
                splitContainer4.Panel2.Controls.Add(vizcore3dView);
            }


            // Event
            vizcore3dMain.OnInitializedVIZCore3D += VIZCore3D_Main_OnInitializedVIZCore3D;
            vizcore3dDisassembly.OnInitializedVIZCore3D += VIZCore3D_Disassembly_OnInitializedVIZCore3D;
            vizcore3dGrid.OnInitializedVIZCore3D += VIZCore3D_Grid_OnInitializedVIZCore3D;
            vizcore3dView.OnInitializedVIZCore3D += VIZCore3D_View_OnInitializedVIZCore3D;
        }

        // ================================================
        // Event - VIZCore3D.NET
        // ================================================
        #region Event - OnInitializedVIZCore3D
        private void VIZCore3D_Main_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3DHelper.OnInitializedVIZCore3D(vizcore3dMain);
        }

        private void VIZCore3D_Disassembly_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3DHelper.OnInitializedVIZCore3D(vizcore3dDisassembly);
        }

        private void VIZCore3D_Grid_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3DHelper.OnInitializedVIZCore3D(vizcore3dGrid);
        }

        private void VIZCore3D_View_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3DHelper.OnInitializedVIZCore3D(vizcore3dView);
        }
        #endregion


    }
}
