using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Scheduler
{
    public partial class StatusForm : Office2007Form
    {
        public StatusForm()
        {
            InitializeComponent();
        }

        #region 全局变量

        Timer timer = null;

        #endregion

        #region 公共方法

        private void RefreshStatus()
        {
            //Process currentProcess = Process.GetCurrentProcess();
            //string cpu = "";
            //string ram = "";
            
            //MessageBoxEx.Show(cpu + "|" + ram);
            //CircularScales => Scale => Pointers
            this.gcRAM.SetPointerValue("Pointer1", Process.GetCurrentProcess().WorkingSet64 / 1024.0 / 1024.0);
            this.gcCPU.SetPointerValue("Pointer1", new Random().NextDouble() * 100);
        }

        #endregion

        private void StatusForm_Load(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Enabled = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            RefreshStatus();
        }

    }
}
