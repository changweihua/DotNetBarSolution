using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Scheduler
{
    #region 作者和版权
    /*************************************************************************************
     * CLR 版本:       4.0.30319.17929
     * 类 名 称:       ToolForm
     * 机器名称:       LUMIA800
     * 命名空间:       Scheduler
     * 文 件 名:       ToolForm
     * 创建时间:       2013/1/11 16:39:25
     * 作    者:       常伟华 Changweihua
	 * 版    权:	   ToolForm说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2013
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com  
     * 唯一标识：	   326764a6-9a01-4377-96a1-1c60e7c63521  
	 *
	 * 登录用户:       Changweihua
	 * 所 属 域:       Lumia800

	 * 创建年份:       2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    /// <summary>
    /// 摘要
    /// </summary>
    public partial class ToolForm : Form
    {
        public ToolForm()
        {
            InitializeComponent();
        }

        #region 引用dll，实现窗体拖动

        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        #endregion

        #region 类似QQ的收缩功能，逻辑实现代码

        int QQ_MODE = 0, QQ_T = 3, QQ_XY = 6;//0为不停靠,1为X轴,2为Y轴,3为顶部；QQ_T为显示的像素；QQ_XY为误差
        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果左键按下就不处理当前逻辑[是否收缩]
            if (MouseButtons == MouseButtons.Left)
                return;

            //鼠标的位置
            int x = MousePosition.X, y = MousePosition.Y;

            //鼠标移动到窗口内，显示
            if (x > (this.Location.X - QQ_XY)
                &&
                x < (this.Location.X + this.Width + QQ_XY)
                &&
                y > (this.Location.Y - QQ_XY)
                &&
                y < (this.Location.Y + this.Height + QQ_XY))
            {
                if (this.QQ_MODE == 1)
                    this.Location = new Point(QQ_T, this.Location.Y);
                else if (this.QQ_MODE == 2)
                    this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - QQ_T, this.Location.Y);
                else if (this.QQ_MODE == 3)
                    this.Location = new Point(this.Location.X, QQ_T);
            }
            else//鼠标移动到窗口外，隐藏
            {
                if (this.Location.Y <= QQ_T)//上
                {
                    this.Location = new Point(this.Location.X, QQ_T - this.Height);
                    this.QQ_MODE = 3;
                }
                else if (this.Location.X <= QQ_T)//左
                {
                    this.Location = new Point(QQ_T - this.Width, this.Location.Y);
                    this.QQ_MODE = 1;
                }
                else if (this.Location.X >= Screen.PrimaryScreen.WorkingArea.Width - this.Width - QQ_T)//右
                {
                    this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - QQ_T, this.Location.Y);
                    this.QQ_MODE = 2;
                }
                else
                    this.QQ_MODE = 0;
            }
        }

        //移动窗体时，解决QQ逻辑
        private void ToolForm_Move(object sender, EventArgs e)
        {
            this.QQ_MODE = 0;
        }

        #endregion

        private void ToolForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        #region 窗体拖动方法

        /// <summary>
        /// 窗体拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        #endregion
        
    }
}
