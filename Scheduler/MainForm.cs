using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using NLite.Data;

namespace Scheduler
{
    public partial class MainForm : Office2007Form
    {
        #region 全局变量

        //关于窗体变量
        AboutForm aboutForm = null;
        SettingForm settingForm = null;

        #endregion

        #region 构造函数

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体方法

        private void MainForm_Load(object sender, EventArgs e)
        {
            //设置窗体最大化
            this.WindowState = FormWindowState.Maximized;
            //关闭MessageBoxEx的Glass效果
            MessageBoxEx.EnableGlass = false;
            //加载计划列表
            LoadScheduler(DateTime.Now);
            //记录日志
            MainLogger.Instance.Trace("加载主窗体");
            //实例化关于窗体
            aboutForm = new AboutForm();
            settingForm = new SettingForm();
        }

        #endregion

        #region MonthCalendar控件方法

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            //选中日期，动态改变Scheduler的日期
            this.schdedulerCalendar.DayViewDate = e.Start;
        }

        #endregion

        #region SchedulerCalendar控件方法

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

        /// <summary>
        /// 加载指定日期的计划项
        /// </summary>
        /// <param name="dt"></param>
        private void LoadScheduler(DateTime dt)
        {
            List<Appointment> appointments = null;
            using (var ctx = DbConfiguration.Items["Scheduler"].CreateDbContext())
            {
                appointments = ctx.Set<Appointment>().Where(a => a.StartTime.Date == dt.Date).ToList();
            }
        }

        #endregion

        #region SchedulerCalendar ContextMenu控件

        /// <summary>
        /// 新建约会
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 转到今天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiGotoToday_Click(object sender, EventArgs e)
        {
            this.schdedulerCalendar.DayViewDate = DateTime.Now;
        }

        /// <summary>
        /// 切换到日视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDayView_Click(object sender, EventArgs e)
        {
            this.schdedulerCalendar.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Day;
        }

        /// <summary>
        /// 切换到周视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiWeekView_Click(object sender, EventArgs e)
        {
            this.schdedulerCalendar.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Week;
        }

        /// <summary>
        /// 切换到月视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiMonthView_Click(object sender, EventArgs e)
        {
            this.schdedulerCalendar.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Month;
        }

        /// <summary>
        /// 切换到时光轴视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTimelineView_Click(object sender, EventArgs e)
        {
            this.schdedulerCalendar.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.TimeLine;
        }

        /// <summary>
        /// 跳转到指定日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiGotoDefinedDay_Click(object sender, EventArgs e)
        {
            new ChooseDateForm().ShowDialog(this);
        }

        #endregion

        #region 公共方法

        void FillScheduler(List<Appointment> list)
        {
            foreach (var item in list)
            {

            }
        }

        #endregion

        #region 托盘功能区

        /// <summary>
        /// 显示主窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiShow_Click(object sender, EventArgs e)
        {
            schdulerNotifyIcon_DoubleClick(sender, e);
        }

        /// <summary>
        /// 双击托盘图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void schdulerNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            if (aboutForm.WindowState == FormWindowState.Normal)
            {
                aboutForm.Close();
            }

            // Activate the form.
            this.Show();
            this.ShowInTaskbar = true;
            this.schdulerNotifyIcon.Visible = false;
            this.Activate();
        }

        /// <summary>
        /// 窗体大小调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                schdulerNotifyIcon.Visible = true;
                schdulerNotifyIcon.BalloonTipTitle = "提示";
                schdulerNotifyIcon.BalloonTipText = "程序仍在运行,双击图标显示主窗体";
                schdulerNotifyIcon.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        /// <summary>
        /// 查看程序信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            aboutForm.Show();
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        #endregion

        private void biAboutSystem_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }

        private void biSystemSetting_Click(object sender, EventArgs e)
        {
            settingForm.ShowDialog();
        }

    }
}
