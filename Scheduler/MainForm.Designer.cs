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
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.monthCalendar = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.schdulerNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationBar2 = new DevComponents.DotNetBar.NavigationBar();
            this.biSystemSetting = new DevComponents.DotNetBar.ButtonItem();
            this.biAboutSystem = new DevComponents.DotNetBar.ButtonItem();
            this.biSystemStatus = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.biSaveScheduler = new DevComponents.DotNetBar.ButtonItem();
            this.biClearScheduler = new DevComponents.DotNetBar.ButtonItem();
            this.biImportOrExportScheduler = new DevComponents.DotNetBar.ButtonItem();
            this.biLoadScheduler = new DevComponents.DotNetBar.ButtonItem();
            this.schedulerContextMenuStrip.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
            this.navigationPanePanel1.SuspendLayout();
            this.cmsNotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar2)).BeginInit();
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
            this.schdedulerCalendar.LabelTimeSlots = true;
            this.schdedulerCalendar.Location = new System.Drawing.Point(252, 0);
            this.schdedulerCalendar.MultiUserTabHeight = 20;
            this.schdedulerCalendar.Name = "schdedulerCalendar";
            this.schdedulerCalendar.Size = new System.Drawing.Size(793, 623);
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
            this.schedulerContextMenuStrip.Size = new System.Drawing.Size(147, 126);
            // 
            // tsmiNewAppointment
            // 
            this.tsmiNewAppointment.Name = "tsmiNewAppointment";
            this.tsmiNewAppointment.Size = new System.Drawing.Size(146, 22);
            this.tsmiNewAppointment.Text = "新约会";
            this.tsmiNewAppointment.Click += new System.EventHandler(this.tsmiNewAppointment_Click);
            // 
            // dsaToolStripMenuItem1
            // 
            this.dsaToolStripMenuItem1.Name = "dsaToolStripMenuItem1";
            this.dsaToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.dsaToolStripMenuItem1.Text = "全天事件";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // tsmiGotoToday
            // 
            this.tsmiGotoToday.Name = "tsmiGotoToday";
            this.tsmiGotoToday.Size = new System.Drawing.Size(146, 22);
            this.tsmiGotoToday.Text = "转到今天";
            this.tsmiGotoToday.Click += new System.EventHandler(this.tsmiGotoToday_Click);
            // 
            // tsmiGotoDefinedDay
            // 
            this.tsmiGotoDefinedDay.Name = "tsmiGotoDefinedDay";
            this.tsmiGotoDefinedDay.Size = new System.Drawing.Size(146, 22);
            this.tsmiGotoDefinedDay.Text = "转到指定日期";
            this.tsmiGotoDefinedDay.Click += new System.EventHandler(this.tsmiGotoDefinedDay_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // tsmiChangeView
            // 
            this.tsmiChangeView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDayView,
            this.tsmiWeekView,
            this.tsmiMonthView,
            this.tsmiTimelineView});
            this.tsmiChangeView.Name = "tsmiChangeView";
            this.tsmiChangeView.Size = new System.Drawing.Size(146, 22);
            this.tsmiChangeView.Text = "改变视图";
            // 
            // tsmiDayView
            // 
            this.tsmiDayView.Name = "tsmiDayView";
            this.tsmiDayView.Size = new System.Drawing.Size(134, 22);
            this.tsmiDayView.Text = "日视图";
            this.tsmiDayView.Click += new System.EventHandler(this.tsmiDayView_Click);
            // 
            // tsmiWeekView
            // 
            this.tsmiWeekView.Name = "tsmiWeekView";
            this.tsmiWeekView.Size = new System.Drawing.Size(134, 22);
            this.tsmiWeekView.Text = "周视图";
            this.tsmiWeekView.Click += new System.EventHandler(this.tsmiWeekView_Click);
            // 
            // tsmiMonthView
            // 
            this.tsmiMonthView.Name = "tsmiMonthView";
            this.tsmiMonthView.Size = new System.Drawing.Size(134, 22);
            this.tsmiMonthView.Text = "月视图";
            this.tsmiMonthView.Click += new System.EventHandler(this.tsmiMonthView_Click);
            // 
            // tsmiTimelineView
            // 
            this.tsmiTimelineView.Name = "tsmiTimelineView";
            this.tsmiTimelineView.Size = new System.Drawing.Size(134, 22);
            this.tsmiTimelineView.Text = "时间线视图";
            this.tsmiTimelineView.Click += new System.EventHandler(this.tsmiTimelineView_Click);
            // 
            // calendarImageList
            // 
            this.calendarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("calendarImageList.ImageStream")));
            this.calendarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.calendarImageList.Images.SetKeyName(0, "about.png");
            this.calendarImageList.Images.SetKeyName(1, "setting.png");
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.navigationPane1);
            this.expandablePanel1.Controls.Add(this.monthCalendar);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(252, 623);
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
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biLoadScheduler,
            this.buttonItem2});
            this.navigationPane1.Location = new System.Drawing.Point(0, 311);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Size = new System.Drawing.Size(252, 312);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 2;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(252, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPane1.TitlePanel.Style.GradientAngle = 90;
            this.navigationPane1.TitlePanel.Style.MarginLeft = 4;
            this.navigationPane1.TitlePanel.TabIndex = 0;
            this.navigationPane1.TitlePanel.Text = "日历选项";
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.navigationPanePanel2.Controls.Add(this.navigationBar1);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(0, 24);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.buttonItem2;
            this.navigationPanePanel2.Size = new System.Drawing.Size(252, 256);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // navigationBar1
            // 
            this.navigationBar1.BackgroundStyle.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.navigationBar1.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationBar1.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationBar1.ItemPaddingBottom = 2;
            this.navigationBar1.ItemPaddingTop = 2;
            this.navigationBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biSystemSetting,
            this.biAboutSystem,
            this.biSystemStatus});
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(252, 133);
            this.navigationBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationBar1.TabIndex = 0;
            this.navigationBar1.Text = "systemNavigationBar";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.AutoSize = true;
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.navigationPanePanel1.Controls.Add(this.navigationBar2);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Location = new System.Drawing.Point(0, 0);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.biLoadScheduler;
            this.navigationPanePanel1.Size = new System.Drawing.Size(252, 312);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
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
            // schdulerNotifyIcon
            // 
            this.schdulerNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.schdulerNotifyIcon.ContextMenuStrip = this.cmsNotifyIcon;
            this.schdulerNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("schdulerNotifyIcon.Icon")));
            this.schdulerNotifyIcon.Text = "notifyIcon1";
            this.schdulerNotifyIcon.DoubleClick += new System.EventHandler(this.schdulerNotifyIcon_DoubleClick);
            // 
            // cmsNotifyIcon
            // 
            this.cmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.toolStripSeparator3,
            this.tsmiAbout,
            this.toolStripSeparator4,
            this.tsmiExit});
            this.cmsNotifyIcon.Name = "cmsNotifyIcon";
            this.cmsNotifyIcon.Size = new System.Drawing.Size(123, 82);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(122, 22);
            this.tsmiShow.Text = "显示程序";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(122, 22);
            this.tsmiAbout.Text = "关于程序";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(119, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(122, 22);
            this.tsmiExit.Text = "退出程序";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // navigationBar2
            // 
            this.navigationBar2.BackgroundStyle.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.navigationBar2.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationBar2.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationBar2.ItemPaddingBottom = 2;
            this.navigationBar2.ItemPaddingTop = 2;
            this.navigationBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem5,
            this.biSaveScheduler,
            this.biClearScheduler,
            this.biImportOrExportScheduler});
            this.navigationBar2.Location = new System.Drawing.Point(0, 0);
            this.navigationBar2.Name = "navigationBar2";
            this.navigationBar2.Size = new System.Drawing.Size(252, 168);
            this.navigationBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationBar2.TabIndex = 0;
            this.navigationBar2.Text = "navigationBar2";
            // 
            // biSystemSetting
            // 
            this.biSystemSetting.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biSystemSetting.Checked = true;
            this.biSystemSetting.Image = ((System.Drawing.Image)(resources.GetObject("biSystemSetting.Image")));
            this.biSystemSetting.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Large;
            this.biSystemSetting.Name = "biSystemSetting";
            this.biSystemSetting.OptionGroup = "navBar";
            this.biSystemSetting.Text = "系统设置";
            this.biSystemSetting.Click += new System.EventHandler(this.biSystemSetting_Click);
            // 
            // biAboutSystem
            // 
            this.biAboutSystem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biAboutSystem.Checked = true;
            this.biAboutSystem.Image = global::Scheduler.Properties.Resources.about1;
            this.biAboutSystem.Name = "biAboutSystem";
            this.biAboutSystem.OptionGroup = "navBar";
            this.biAboutSystem.Text = "关于系统";
            this.biAboutSystem.Click += new System.EventHandler(this.biAboutSystem_Click);
            // 
            // biSystemStatus
            // 
            this.biSystemStatus.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biSystemStatus.Image = global::Scheduler.Properties.Resources.systemMonitor;
            this.biSystemStatus.Name = "biSystemStatus";
            this.biSystemStatus.OptionGroup = "navBar";
            this.biSystemStatus.Text = "程序状态";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Checked = true;
            this.buttonItem2.Image = global::Scheduler.Properties.Resources.system;
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.OptionGroup = "navBar";
            this.buttonItem2.Text = "系统选项";
            this.buttonItem2.Tooltip = "系统的相关操作";
            // 
            // buttonItem5
            // 
            this.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem5.Checked = true;
            this.buttonItem5.Image = global::Scheduler.Properties.Resources.loadScheduler;
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.OptionGroup = "navBar";
            this.buttonItem5.Text = "加载日历";
            // 
            // biSaveScheduler
            // 
            this.biSaveScheduler.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biSaveScheduler.Image = global::Scheduler.Properties.Resources.saveScheduler;
            this.biSaveScheduler.Name = "biSaveScheduler";
            this.biSaveScheduler.OptionGroup = "navBar";
            this.biSaveScheduler.Text = "保存日历";
            // 
            // biClearScheduler
            // 
            this.biClearScheduler.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biClearScheduler.Image = global::Scheduler.Properties.Resources.clearScheduler;
            this.biClearScheduler.Name = "biClearScheduler";
            this.biClearScheduler.OptionGroup = "navBar";
            this.biClearScheduler.Text = "清空日历";
            // 
            // biImportOrExportScheduler
            // 
            this.biImportOrExportScheduler.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biImportOrExportScheduler.Checked = true;
            this.biImportOrExportScheduler.Image = global::Scheduler.Properties.Resources.editScheduler;
            this.biImportOrExportScheduler.Name = "biImportOrExportScheduler";
            this.biImportOrExportScheduler.OptionGroup = "navBar";
            this.biImportOrExportScheduler.Text = "导入导出日历";
            // 
            // biLoadScheduler
            // 
            this.biLoadScheduler.Checked = true;
            this.biLoadScheduler.Image = global::Scheduler.Properties.Resources.chooseScheduler;
            this.biLoadScheduler.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.biLoadScheduler.Name = "biLoadScheduler";
            this.biLoadScheduler.OptionGroup = "navBar";
            this.biLoadScheduler.Text = "日历选项";
            this.biLoadScheduler.Tooltip = "这里进行日历相关的操作";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("浪漫雅圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(1045, 623);
            this.Controls.Add(this.schdedulerCalendar);
            this.Controls.Add(this.expandablePanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的日历";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.schedulerContextMenuStrip.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.expandablePanel1.PerformLayout();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPane1.PerformLayout();
            this.navigationPanePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.navigationPanePanel1.ResumeLayout(false);
            this.cmsNotifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Schedule.CalendarView schdedulerCalendar;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv monthCalendar;
        private System.Windows.Forms.ImageList calendarImageList;
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
        private System.Windows.Forms.NotifyIcon schdulerNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmsNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.ButtonItem biLoadScheduler;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.ButtonItem biSystemSetting;
        private DevComponents.DotNetBar.ButtonItem biAboutSystem;
        private DevComponents.DotNetBar.NavigationBar navigationBar2;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem biSaveScheduler;
        private DevComponents.DotNetBar.ButtonItem biClearScheduler;
        private DevComponents.DotNetBar.ButtonItem biImportOrExportScheduler;
        private DevComponents.DotNetBar.ButtonItem biSystemStatus;

    }
}

