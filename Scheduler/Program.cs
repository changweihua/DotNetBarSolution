using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NLite.Data;

namespace Scheduler
{
    static class Program
    {

        #region 实现任意时刻是打开一个程序

        private const int WS_SHOWNORMAL = 1;
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Process instance = GetRunningInstance();
                if (instance == null)
                {
                    //处理未捕获的异常
                    Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                    //处理UI线程异常
                    Application.ThreadException += Application_ThreadException;
                    //处理非UI线程异常
                    AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    DbConfiguration cfg = DbConfiguration
                       .Configure("Scheduler")
                       .AddClass<Appointment>()
                       .AddClass<AppointmentLabel>()
                       .AddClass<AppointmentDisplay>();
                    MainLogger.Instance.Trace("开始运行");
                    Application.Run(new MainForm());
                }
                else
                {
                    HandleRunningInstance(instance);
                }
            }
            catch (Exception ex)
            {
                MainLogger.Instance.Trace(ex.Message);
                //提示窗体
                new ErrorForm().ShowDialog();
            }

        }

        /// <summary>
        /// 获取当前是否具有相同进程。
        /// </summary>
        /// <returns></returns>
        public static Process GetRunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //遍历正在有相同名字运行的例程   
            foreach (Process process in processes)
            {
                //忽略现有的例程   
                if (process.Id != current.Id)
                    //确保例程从EXE文件运行 
                    if (System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                        return process;
            }
            return null;
        }
        /// <summary>
        /// 激活原有的进程。
        /// </summary>
        /// <param name="instance"></param>
        public static void HandleRunningInstance(Process instance)
        {
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL);
            SetForegroundWindow(instance.MainWindowHandle);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                MainLogger.Instance.Trace(ex.Source + ex.Message);
            }
            else
            {
                MainLogger.Instance.Trace("非UI线程异常");
            }
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MainLogger.Instance.Trace(e.Exception.Source + e.Exception.Message);
        }
    }
}
