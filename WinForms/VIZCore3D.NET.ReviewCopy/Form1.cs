using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VIZCore3D.NET.Event;

namespace VIZCore3D.NET.ReviewCopy
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// VIZCore3D.NET
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        private int _slectedReviewID = 0;

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

            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            // 라이선스 서버 주소 입력
            vizcore3d.License.LicenseServer("127.0.0.1", 8901);

            vizcore3d.Review.OnReviewChangedEvent += Review_OnReviewChangedEvent;
            vizcore3d.GeometryUtility.OnOsnapPickingItem += GeometryUtility_OnOsnapPickingItem;
        }

        /// <summary>
        /// Osnap 피킹 포인트 선택 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeometryUtility_OnOsnapPickingItem(object sender, EventManager.OsnapPickingItemEventArgs e)
        {
            var reviewItem = vizcore3d.Review.GetItem(_slectedReviewID);

            // 리뷰 타입에 따라 리뷰 생성 하는 방식 다르게 [ 필요에 따라 아래 API 주소를 참고 하여 추가 ]
            // 리뷰 타입은 https://softhills.net/SHDC/VIZCore3D.NET/Help/html/T_VIZCore3D_NET_Manager_ReviewManager_ReviewKind.htm 참고
            switch (reviewItem.Kind)
            {
                case Manager.ReviewManager.ReviewKind.RK_SURFACE_NOTE:
                    vizcore3d.Review.Note.AddNoteSurface(reviewItem.Title, e.Point.X, e.Point.Y, e.Point.Z);
                    break;
                case Manager.ReviewManager.ReviewKind.RK_2D_NOTE:
                    vizcore3d.Review.Note.AddNote2D(reviewItem.Title, e.Point.X, e.Point.Y, e.Point.Z);
                    break;
                case Manager.ReviewManager.ReviewKind.RK_3D_NOTE:
                    vizcore3d.Review.Note.AddNote3D(reviewItem.Title, e.Point.X, e.Point.Y, e.Point.Z);
                    break;
                default:
                    break;
            }

            vizcore3d.View.Message.Clear();
        }

        /// <summary>
        /// 리뷰 변경 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Review_OnReviewChangedEvent(object sender, EventManager.ReviewEventArgs e)
        {
            if (e.EventKind == Manager.ReviewManager.ReviewEventKind.CHANGED_REVIEW_DATA)
            {
                // 리뷰가 추가 되거나 변경 되는 경우
                var revieItem = vizcore3d.Review.GetItem(e.ReviewID);
                var type = revieItem.Kind.ToString();

                if (type.Contains("NOTE"))
                {
                    type = "Note";
                }
                else
                {
                    type = "Unknown Type";
                }

                // 타입 분류 후 데이터 추가
                dataGridView1.Rows.Add($"{e.ReviewID}", type);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 노트 복사
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                _slectedReviewID = int.Parse(selectedRow.Cells["ID"].Value.ToString());

                // 개체 선택 시 피킹 포인트 선택 이벤트
                vizcore3d.GeometryUtility.ShowOsnap(true, true, true, true);
            }
            else
            {
                MessageBox.Show("복사할 리뷰를 선택하세요.", "VIZCore3D.NET");
            }
        }
    }
}
