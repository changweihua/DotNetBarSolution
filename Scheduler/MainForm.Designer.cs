namespace Scheduler
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainFormStyleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.schdedulerCalendar = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.schedulerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNewAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.dsaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiGotoToday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGotoDefinedDay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiChangeView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDayView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWeekView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMonthView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimelineView = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarImageList = new System.Windows.Forms.ImageList(this.components);
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnXSave = new DevComponents.DotNetBar.ButtonX();
            this.monthCalendar = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.schedulerContextMenuStrip.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormStyleManager
            // 
            this.mainFormStyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.mainFormStyleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // schdedulerCalendar
            // 
            this.schdedulerCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.schdedulerCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.schdedulerCalendar.ContainerControlProcessDialogKey = true;
            this.schdedulerCalendar.ContextMenuStrip = this.schedulerContextMenuStrip;
            this.schdedulerCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schdedulerCalendar.HighlightCurrentDay = true;
            this.schdedulerCalendar.Images = this.calendarImageList;
            this.schdedulerCalendar.Is24HourFormat = true;
            this.schdedulerCalendar.Location = new System.Drawing.Point(252, 0);
            this.schdedulerCalendar.MultiUserTabHeight = 20;
            this.schdedulerCalendar.Name = "schdedulerCalendar";
            this.schdedulerCalendar.Size = new System.Drawing.Size(793, 468);
            this.schdedulerCalendar.TabIndex = 0;
            this.schdedulerCalendar.Text = "calendarView1";
            this.schdedulerCalendar.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.schdedulerCalendar.TimeIndicator.Tag = null;
            this.schdedulerCalendar.TimeSlotDuration = 30;
            this.schdedulerCalendar.YearViewAppointmentLinkStyle = DevComponents.DotNetBar.Schedule.eYearViewLinkStyle.Style2;
            this.schdedulerCalendar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.schdedulerCalendar_MouseClick);
            // 
            // schedulerContextMenuStrip
            // 
            this.schedulerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewAppointment,
            this.dsaToolStripMenuItem1,
            this.toolStripSeparator1,
            this.tsmiGotoToday,
            this.tsmiGotoDefinedDay,
            this.toolStripSeparator2,
            this.tsmiChangeView});
            this.schedulerContextMenuStrip.Name = "contextMenuStrip1";
            this.schedulerContextMenuStrip.Size = new System.Drawing.Size(153, 148);
            // 
            // tsmiNewAppointment
            // 
            this.tsmiNewAppointment.Image = global::Scheduler.Properties.Resources.newAppointment;
            this.tsmiNewAppointment.Name = "tsmiNewAppointment";
            this.tsmiNewAppointment.Size = new System.Drawing.Size(152, 22);
            this.tsmiNewAppointment.Text = "新约会";
            this.tsmiNewAppointment.Click += new System.EventHandler(this.tsmiNewAppointment_Click);
            // 
            // dsaToolStripMenuItem1
            // 
            this.dsaToolStripMenuItem1.Image = global::Scheduler.Properties.Resources.newAllDayEvent;
            this.dsaToolStripMenuItem1.Name = "dsaToolStripMenuItem1";
            this.dsaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dsaToolStripMenuItem1.Text = "全天事件";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiGotoToday
            // 
            this.tsmiGotoToday.Image = global::Scheduler.Properties.Resources.gotoToday;
            this.tsmiGotoToday.Name = "tsmiGotoToday";
            this.tsmiGotoToday.Size = new System.Drawing.Size(152, 22);
            this.tsmiGotoToday.Text = "转到今天";
            this.tsmiGotoToday.Click += new System.EventHandler(this.tsmiGotoToday_Click);
            // 
            // tsmiGotoDefinedDay
            // 
            this.tsmiGotoDefinedDay.Image = global::Scheduler.Properties.Resources.gotoTheDay;
            this.tsmiGotoDefinedDay.Name = "tsmiGotoDefinedDay";
            this.tsmiGotoDefinedDay.Size = new System.Drawing.Size(152, 22);
            this.tsmiGotoDefinedDay.Text = "转到指定日期";
            this.tsmiGotoDefinedDay.Click += new System.EventHandler(this.tsmiGotoDefinedDay_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiChangeView
            // 
            this.tsmiChangeView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDayView,
            this.tsmiWeekView,
            this.tsmiMonthView,
            this.tsmiTimelineView});
            this.tsmiChangeView.Image = global::Scheduler.Properties.Resources.changeView;
            this.tsmiChangeView.Name = "tsmiChangeView";
            this.tsmiChangeView.Size = new System.Drawing.Size(152, 22);
            this.tsmiChangeView.Text = "改变视图";
            // 
            // tsmiDayView
            // 
            this.tsmiDayView.Name = "tsmiDayView";
            this.tsmiDayView.Size = new System.Drawing.Size(152, 22);
            this.tsmiDayView.Text = "日视图";
            this.tsmiDayView.Click += new System.EventHandler(this.tsmiDayView_Click);
            // 
            // tsmiWeekView
            // 
            this.tsmiWeekView.Name = "tsmiWeekView";
            this.tsmiWeekView.Size = new System.Drawing.Size(152, 22);
            this.tsmiWeekView.Text = "周视图";
            this.tsmiWeekView.Click += new System.EventHandler(this.tsmiWeekView_Click);
            // 
            // tsmiMonthView
            // 
            this.tsmiMonthView.Name = "tsmiMonthView";
            this.tsmiMonthView.Size = new System.Drawing.Size(152, 22);
            this.tsmiMonthView.Text = "月视图";
            this.tsmiMonthView.Click += new System.EventHandler(this.tsmiMonthView_Click);
            // 
            // tsmiTimelineView
            // 
            this.tsmiTimelineView.Name = "tsmiTimelineView";
            this.tsmiTimelineView.Size = new System.Drawing.Size(152, 22);
            this.tsmiTimelineView.Text = "时间线视图";
            this.tsmiTimelineView.Click += new System.EventHandler(this.tsmiTimelineView_Click);
            // 
            // calendarImageList
            // 
            this.calendarImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.calendarImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.calendarImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.switchButton1);
            this.expandablePanel1.Controls.Add(this.btnXSave);
            this.expandablePanel1.Controls.Add(this.monthCalendar);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(252, 468);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 1;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "导航栏";
            // 
            // btnXSave
            // 
            this.btnXSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnXSave.Location = new System.Drawing.Point(3, 319);
            this.btnXSave.Name = "btnXSave";
            this.btnXSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnXSave.Size = new System.Drawing.Size(243, 23);
            this.btnXSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXSave.TabIndex = 0;
            this.btnXSave.Text = "保存日历";
            // 
            // monthCalendar
            // 
            this.monthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.monthCalendar.AutoSize = true;
            // 
            // 
            // 
            this.monthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.monthCalendar.BackgroundStyle.BorderBottomWidth = 1;
            this.monthCalendar.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.monthCalendar.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.monthCalendar.BackgroundStyle.BorderLeftWidth = 1;
            this.monthCalendar.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.monthCalendar.BackgroundStyle.BorderRightWidth = 1;
            this.monthCalendar.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.monthCalendar.BackgroundStyle.BorderTopWidth = 1;
            this.monthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendar.BackgroundStyle.MarginBottom = 5;
            this.monthCalendar.BackgroundStyle.MarginLeft = 5;
            this.monthCalendar.BackgroundStyle.MarginRight = 5;
            this.monthCalendar.BackgroundStyle.MarginTop = 5;
            this.monthCalendar.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.monthCalendar.BackgroundStyle.TextTrimming = DevComponents.DotNetBar.eStyleTextTrimming.Word;
            this.monthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.monthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendar.ContainerControlProcessDialogKey = true;
            this.monthCalendar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.monthCalendar.DaySize = new System.Drawing.Size(30, 30);
            this.monthCalendar.DisplayMonth = new System.DateTime(2012, 12, 30, 0, 0, 0, 0);
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.monthCalendar.Images = this.calendarImageList;
            this.monthCalendar.Location = new System.Drawing.Point(0, 26);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(5);
            this.monthCalendar.MarkedDates = new System.DateTime[0];
            this.monthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            this.monthCalendar.Name = "monthCalendar";
            // 
            // 
            // 
            this.monthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.monthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.monthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.monthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendar.NavigationBackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.Size = new System.Drawing.Size(252, 285);
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.Text = "日历";
            this.monthCalendar.TodayButtonVisible = true;
            this.monthCalendar.TwoLetterDayName = false;
            this.monthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(4, 349);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "开机不启动";
            this.switchButton1.OnText = "开机启动";
            this.switchButton1.Size = new System.Drawing.Size(242, 22);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.SwitchWidth = 121;
            this.switchButton1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("浪漫雅圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(1045, 468);
            this.Controls.Add(this.schdedulerCalendar);
            this.Controls.Add(this.expandablePanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的日历";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.schedulerContextMenuStrip.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.expandablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Schedule.CalendarView schdedulerCalendar;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv monthCalendar;
        private System.Windows.Forms.ImageList calendarImageList;
        private DevComponents.DotNetBar.ButtonX btnXSave;
        private System.Windows.Forms.ContextMenuStrip schedulerContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewAppointment;
        private System.Windows.Forms.ToolStripMenuItem dsaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiGotoToday;
        private System.Windows.Forms.ToolStripMenuItem tsmiGotoDefinedDay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeView;
        private System.Windows.Forms.ToolStripMenuItem tsmiDayView;
        private System.Windows.Forms.ToolStripMenuItem tsmiWeekView;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonthView;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimelineView;
        private DevComponents.DotNetBar.StyleManager mainFormStyleManager;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;

    }
}

