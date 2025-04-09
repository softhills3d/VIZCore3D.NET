using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VIZCore3D.NET.Data;

namespace VIZCore3D.NET.MouseIdleDetector
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// VIZCore3D.NET 컨트롤 인스턴스
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        /// <summary>
        /// 마우스 비활성 감지를 위한 타이머
        /// </summary>
        private Timer idleTimer;

        /// <summary>
        /// 마지막으로 마우스가 움직인 시점
        /// </summary>
        private DateTime lastMouseMoveTime;

        /// <summary>
        /// 마우스가 감지되지 않은 후 경과할 허용 시간 (초)
        /// </summary>
        private int idleThresholdSeconds = 30;

        private readonly string LicenseServerIP = "127.0.0.1";

        private readonly int LicenseServerPort = 8901;

        public Form1()
        {
            InitializeComponent();

            // VIZCore3D.NET 초기화
            VIZCore3D.NET.ModuleInitializer.Run();

            // 컨트롤 생성 및 패널에 추가
            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(vizcore3d);

            // 초기화 및 이벤트 연결
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
        }

        /// <summary>
        /// VIZCore3D 초기화 완료 시 호출됨
        /// </summary>
        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            // 라이선스 서버 설정
            vizcore3d.License.LicenseServer(LicenseServerIP, LicenseServerPort);

            // 마우스 유휴 상태 감지 기능 초기화
            InitIdleChecker();

            // 폼 및 내부 컨트롤에 마우스 이벤트 연결
            RegisterMouseMoveEvents(this);

            // 마우스 이동 이벤트 연결
            vizcore3d.View.OnViewDefaultMouseMoveEvent += View_OnViewDefaultMouseMoveEvent;
        }

        /// <summary>
        /// VIZCore3D 뷰에서 마우스가 움직였을 때 호출됨
        /// </summary>
        private void View_OnViewDefaultMouseMoveEvent(object sender, MouseEventArgs e)
        {
            // VIZCore3D 내부에서도 마우스 움직임 감지하여 idle 상태 해제
            lastMouseMoveTime = DateTime.Now;
        }

        /// <summary>
        /// 전체 폼과 모든 자식 컨트롤에 MouseMove 이벤트를 재귀적으로 연결
        /// </summary>
        private void RegisterMouseMoveEvents(Control parent)
        {
            parent.MouseMove += MouseActivityDetected;

            foreach (Control child in parent.Controls)
            {
                RegisterMouseMoveEvents(child);
            }
        }

        /// <summary>
        /// 마우스 움직임이 감지되었을 때 호출됨
        /// </summary>
        private void MouseActivityDetected(object sender, MouseEventArgs e)
        {
            lastMouseMoveTime = DateTime.Now;
        }

        /// <summary>
        /// 마우스 유휴 상태 감지 타이머 초기화
        /// </summary>
        private void InitIdleChecker()
        {
            lastMouseMoveTime = DateTime.Now;

            idleTimer = new Timer();
            idleTimer.Interval = 1000; // 1초마다 체크
            idleTimer.Tick += IdleTimer_Tick;
            idleTimer.Start();
        }

        /// <summary>
        /// 일정 시간 동안 마우스가 움직이지 않으면 라이선스 서버를 해제
        /// </summary>
        private void IdleTimer_Tick(object sender, EventArgs e)
        {
            // 라이선스 서버에 연결되어 있지 않으면 체크하지 않음
            if (!vizcore3d.License.IsAuthentication())
                return; 

            double idleSeconds = (DateTime.Now - lastMouseMoveTime).TotalSeconds;

#if DEBUG
            Debug.WriteLine($"[DEBUG] 현재 Idle 시간: {idleSeconds:F1}초");
#endif

            if (idleSeconds >= idleThresholdSeconds)
            {
                // 중복 알림 방지
                idleTimer.Stop(); 

                MessageBox.Show("앱 내부에서 마우스 움직임이 없으므로 라이선스 서버를 해제 합니다.",
                                "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 라이선스 서버 연결 해제
                vizcore3d.License.DisconnectServer();

                lastMouseMoveTime = DateTime.Now;
                idleTimer.Start();
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            // 라이선스 서버에 연결 검증
            if (!vizcore3d.License.IsAuthentication())
            {
                LicenseResults result = vizcore3d.License.LicenseServer(LicenseServerIP, LicenseServerPort);
                if (result == LicenseResults.SUCCESS)
                {
                    MessageBox.Show("라이선스 서버에 연결되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vizcore3d.Model.OpenFileDialog();
                }
                else
                {
                    MessageBox.Show($"라이선스 서버 연결 실패: {result}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
