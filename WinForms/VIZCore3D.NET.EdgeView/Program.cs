using System;
using System.Windows.Forms;

namespace VIZCore3D.NET.EdgeView
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // VIZCore3D.NET 네이티브 라이브러리(Interop, ShdCore 등) 추출 - 컨트롤 생성 전에 반드시 호출
            VIZCore3D.NET.ModuleInitializer.Run();

            Application.Run(new MainForm());
        }
    }
}
