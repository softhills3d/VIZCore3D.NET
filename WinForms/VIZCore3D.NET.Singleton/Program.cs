using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VIZCore3D.NET.Singleton
{
    static class Program
    {
        /// <summary>
        /// Application Unique Name
        /// </summary>
        public const string Key_AppUniqueName = "SDV";

        /// <summary>
        /// Singleton Application Mutex
        /// </summary>
        public static SingletonAppMutex appMutex;

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Singleton Application Mutex
            appMutex = new SingletonAppMutex();

            if (appMutex.IsRunning(Key_AppUniqueName) == true)
            {
                if (args != null && args.Length > 0)
                {
                    // 파라미터 조회
                    string urlSchemeParam = string.Join("?", args);

                    // 값이 있는 경우 기존 프로세스에 전달
                    if (String.IsNullOrEmpty(urlSchemeParam) == false)
                    {
                        bool result = SingletonMessageHelper.SendBroadcastMessage(urlSchemeParam);

                        if (result == false)
                            MessageBox.Show("Can't Send Message.", "VIZCore3D.NET.Singleton", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return;
            }

            appMutex.SetEvent(Key_AppUniqueName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmMain(args));

            appMutex.InitEvent();
        }
    }
}
