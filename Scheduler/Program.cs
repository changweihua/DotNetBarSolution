using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NLite.Data;

namespace Scheduler
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
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
            catch (Exception ex)
            {
                MainLogger.Instance.Trace(ex.Message);
                //提示窗体
                new ErrorForm().ShowDialog();
            }
            
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
