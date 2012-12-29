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
            this.dateTimeInputEnd.Value = end ?? DateTime.Now;
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
                    this.DialogResult = DialogResult.OK;
                    break;
                case "cancel":
                    this.DialogResult = DialogResult.Cancel;
                    break;
                default:
                    break;
            }
        }

        #endregion

        

    }
}
