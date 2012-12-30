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
            //关闭MessageBoxEx的Glass效果
            MessageBoxEx.EnableGlass = false;
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
            DialogResult dr = new AppointmentForm(start, end).ShowDialog();
            //关闭Glass效果，实现皮肤
            //MessageBoxEx.EnableGlass = false;
            //MessageBoxEx.EnableGlass = false;
            //if (dr == DialogResult.Cancel)
            //{
            //    MessageBoxEx.Show(this, "用户放弃", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (dr == DialogResult.OK)
            //{
            //    MessageBoxEx.Show(this, "用户保存", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
