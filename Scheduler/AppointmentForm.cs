using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using NLite.Data;

namespace Scheduler
{
    public partial class AppointmentForm : Office2007Form
    {
        #region 构造函数

        public AppointmentForm()
        {
            InitializeComponent();
        }

        public AppointmentForm(DateTime? start, DateTime? end)
        {
            InitializeComponent();
            //如果没有传入时间范围，默认为当前时间
            this.dateTimeInputStart.Value = start ?? DateTime.Now;
            this.dateTimeInputEnd.Value = end ?? DateTime.Now.AddHours(1);
        }

        #endregion

        #region TextBox事件

        /// <summary>
        /// 监听主题输入框，与窗体标题一致
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxSubject_TextChanged(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} -- 约会", (sender as TextBoxX).Text);
        }

        #endregion

        #region Command处理

        /// <summary>
        /// 按钮命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCommand_Executed(object sender, EventArgs e)
        {
            string parameter = (sender as ButtonX).CommandParameter == null ? "" : (sender as ButtonX).CommandParameter.ToString();
            
            switch (parameter)
            {
                case "save":
                    Save();
                    break;
                case "cancel":
                    this.DialogResult = DialogResult.Cancel;
                    break;
                default:
                    this.DialogResult = DialogResult.No;
                    break;
            }
        }

        /// <summary>
        /// 保存约会
        /// </summary>
        private void Save()
        {
            string subject = tbxSubject.Text;
            string location = tbxLocation.Text;
            DateTime start = dateTimeInputStart.Value;
            DateTime end = dateTimeInputEnd.Value;
            int labelId = (int)this.cbeLabel.SelectedValue;
            int displayId = (int)this.cbeDisplay.SelectedValue;
            string description = richTextBoxEx1.Text;
            int remindable = Convert.ToInt32(switchButton1.ValueTrue);

            Appointment appointment = new Appointment
            {
                Description = description,
                DisplayId = displayId,
                EndTime = end,
                LabelId = labelId,
                Location = location,
                Remindable = remindable,
                StartTime = start,
                Subject = subject
            };

            int count = 0;
            using (var ctx = DbConfiguration.Items["Scheduler"].CreateDbContext())
            {
                count = ctx.Set<Appointment>().Insert(appointment);
            }
            if (count == 1)
            {
                MessageBoxEx.Show(this, "添加成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                if (MessageBoxEx.Show(this, "添加失败,是否尝试重新保存", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Save();
                }
                else
                {
                    this.Close();
                }
            }

        }

        #endregion

        #region 初始化窗体控件

        private void InitCbeLabel()
        {
            #region 废弃

            //List<ComboBoxItem> items = new List<ComboBoxItem>();
            //items.Add(new ComboBoxItem { Text = "无"});
            //items.Add(new ComboBoxItem { Text = "重要" });
            //items.Add(new ComboBoxItem { Text = "商务" });
            //items.Add(new ComboBoxItem { Text = "私人" });
            //items.Add(new ComboBoxItem { Text = "假日" });
            //items.Add(new ComboBoxItem { Text = "务必出席" });
            //items.Add(new ComboBoxItem { Text = "出差" });
            //items.Add(new ComboBoxItem { Text = "提前准备" });
            //items.Add(new ComboBoxItem { Text = "生日" });
            //items.Add(new ComboBoxItem { Text = "周年纪念日" });
            //items.Add(new ComboBoxItem { Text = "打电话" });
            //items.Add(new ComboBoxItem { Text = "发邮件" });

            #endregion

            List<AppointmentLabel> labels = null;
            using (var ctx = DbConfiguration.Items["Scheduler"].CreateDbContext())
            {
                labels = ctx.Set<AppointmentLabel>().ToList();
            }

            this.cbeLabel.DisplayMember = "DisplayText";
            this.cbeLabel.ValueMember = "Id";
            this.cbeLabel.DataSource = labels;
            this.cbeLabel.SelectedIndex = 0;
        }

        private void InitCbeDisplay()
        {
            #region 废弃

            //List<ComboBoxItem> items = new List<ComboBoxItem>();
            //items.Add(new ComboBoxItem { Text = "空闲" });
            //items.Add(new ComboBoxItem { Text = "暂定" });
            //items.Add(new ComboBoxItem { Text = "忙碌" });
            //items.Add(new ComboBoxItem { Text = "不在办公室" });

            #endregion

            List<AppointmentDisplay> displays = null;
            using (var ctx = DbConfiguration.Items["Scheduler"].CreateDbContext())
            {
                displays = ctx.Set<AppointmentDisplay>().ToList();
            }

            this.cbeDisplay.DisplayMember = "DisplayText";
            this.cbeDisplay.ValueMember = "Id";
            this.cbeDisplay.DataSource = displays;
            this.cbeDisplay.SelectedIndex = 0;
        }


        #endregion

        #region 窗体加载

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            InitCbeLabel();
            InitCbeDisplay();
            MessageBoxEx.EnableGlass = false;
        }

        #endregion

    }
}
