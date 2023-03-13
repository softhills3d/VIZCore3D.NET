using System;
using System.Runtime.InteropServices;

namespace VIZCore3D.NET.Singleton
{
    /// <summary>
    /// 싱글톤 아키텍처 기반 메시지 처리 지원 클래스
    /// </summary>
    public sealed class SingletonMessageHelper
    {
        /// <summary>
        /// BROADCAST MESSAGE HANDLE ID
        /// </summary>
        public const int HWND_BROADCAST = 0xffff;
        /// <summary>
        /// OPEN MESSAGE ID
        /// </summary>
        public static uint WM_OPEN_FILE = 0x4A;

        /// <summary>
        /// Send Message (Win32)
        /// </summary>
        /// <param name="hWnd">Handle</param>
        /// <param name="Msg">Message</param>
        /// <param name="wParam">Additional message-specific information.</param>
        /// <param name="lParam">Additional message-specific information.</param>
        /// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, ref COPYDATASTRUCT lParam);

        /// <summary>
        /// Send Message (Win32)
        /// </summary>
        /// <param name="hWnd">Handle</param>
        /// <param name="Msg">Message</param>
        /// <param name="wParam">Additional message-specific information.</param>
        /// <param name="lParam">Additional message-specific information.</param>
        /// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, ref OBJDATASTRUCT lParam);


        /// <summary>
        /// 메시지 자료구조
        /// </summary>
        public struct OBJDATASTRUCT
        {
            /// <summary>
            /// 데이터 개수
            /// </summary>
            public int iDataNum;
            /// <summary>
            /// 화면에 표시된 노드 인덱스
            /// </summary>
            public int[] index;
            /// <summary>
            /// 노드 컬러 정보
            /// </summary>
            public string[] szSelectedIndex;
            /// <summary>
            /// 노드 트랜스폼 정보
            /// </summary>
            public string[] szTransform;
            /// <summary>
            /// 노드 컬러 정보
            /// </summary>
            public string[] szColor;
        }

        /// <summary>
        /// 메시지 자료구조 사본
        /// </summary>
        public struct COPYDATASTRUCT
        {
            /// <summary>
            /// Data Pointer
            /// </summary>
            public IntPtr dwData;
            /// <summary>
            /// Data Length
            /// </summary>
            public int cbData;
            /// <summary>
            /// 문자열 데이터
            /// </summary>
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }


        /// <summary>
        /// 파일 열기 메시지 전송
        /// </summary>
        /// <param name="MainWindowHandle">Window Handle</param>
        /// <param name="FileName">File Name</param>
        public static void SendOpenFileMessage(IntPtr MainWindowHandle, string FileName)
        {
            byte[] buff = System.Text.Encoding.Default.GetBytes(FileName);

            COPYDATASTRUCT cds = new COPYDATASTRUCT();
            cds.dwData = IntPtr.Zero;
            cds.cbData = buff.Length + 1;
            cds.lpData = FileName;

            SendMessage(MainWindowHandle, WM_OPEN_FILE, 0, ref cds);
        }

        /// <summary>
        /// 파일 열기 메시지 전송
        /// </summary>
        /// <param name="FileName">File Name</param>
        /// <returns>전송 결과</returns>
        public static bool SendOpenFileMessage(string FileName)
        {
            System.Diagnostics.Process CurrentProcess = System.Diagnostics.Process.GetCurrentProcess();

            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(CurrentProcess.ProcessName);
            System.Diagnostics.Process SingletonProcess = null;
            for (int i = 0; i < processes.Length; i++)
            {
                if (processes[i].Id == CurrentProcess.Id) continue;

                SingletonProcess = processes[i];
                break;
            }

            if (SingletonProcess == null) return false;

            byte[] buff = System.Text.Encoding.Default.GetBytes(FileName);

            COPYDATASTRUCT cds = new COPYDATASTRUCT();
            cds.dwData = IntPtr.Zero;
            cds.cbData = buff.Length + 1;
            cds.lpData = FileName;

            SendMessage(SingletonProcess.Handle, WM_OPEN_FILE, 0, ref cds);

            return true;
        }

        /// <summary>
        /// Broadcast 메시지 발송
        /// </summary>
        /// <param name="FileName">조회할 파일 이름 (경로 + 파일이름)</param>
        /// <returns>발송 결과</returns>
        public static bool SendBroadcastMessage(string FileName)
        {
            byte[] buff = System.Text.Encoding.Default.GetBytes(FileName);

            COPYDATASTRUCT cds = new COPYDATASTRUCT();
            cds.dwData = IntPtr.Zero;
            cds.cbData = buff.Length + 1;
            cds.lpData = FileName;

            SendMessage((IntPtr)HWND_BROADCAST, WM_OPEN_FILE, 0, ref cds);

            return true;
        }
    }
}
