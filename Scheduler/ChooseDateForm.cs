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
    public partial class ChooseDateForm : Office2007Form
    {
        public ChooseDateForm()
        {
            InitializeComponent();
        }

        private void buttonCommand_Executed(object sender, EventArgs e)
        {
            string parameter = (sender as ButtonX).CommandParameter.ToString();

            switch (parameter)
            {
                case "ok":
                    MessageBoxEx.Show("您点击了确定按钮");
                    break;
                case "cancel":
                    this.Close();
                    break;
                default:
                    break;
            }

        }

        private void ChooseDateForm_Load(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
        }
    }
}
