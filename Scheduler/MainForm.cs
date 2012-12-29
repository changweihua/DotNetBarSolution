using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Scheduler
{
    public partial class MainForm : Office2007Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //设置窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            //选中日期，动态改变Scheduler的日期
            this.schdedulerCalendar.DayViewDate = e.Start;
        }

        private void schdedulerCalendar_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }

        private void tsmiNewAppointment_Click(object sender, EventArgs e)
        {
            //得到选中区域的起始时间
            //MessageBox.Show(this.schdedulerCalendar.DateSelectionStart.ToString());
            DateTime? start = this.schdedulerCalendar.DateSelectionStart;
            DateTime? end = this.schdedulerCalendar.DateSelectionEnd; 
            new AppointmentForm(start, end).ShowDialog();
        }
    }
}
