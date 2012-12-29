namespace Scheduler
{
    partial class AppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.richTextBoxEx1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbxSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInputStart = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInputEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnxOk = new DevComponents.DotNetBar.ButtonX();
            this.btnxCancel = new DevComponents.DotNetBar.ButtonX();
            this.buttonCommand = new DevComponents.DotNetBar.Command(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "主题";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "地点";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "开始时间";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 99);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "结束时间";
            // 
            // richTextBoxEx1
            // 
            // 
            // 
            // 
            this.richTextBoxEx1.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx1.Location = new System.Drawing.Point(12, 139);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.Size = new System.Drawing.Size(680, 149);
            this.richTextBoxEx1.TabIndex = 1;
            // 
            // tbxSubject
            // 
            // 
            // 
            // 
            this.tbxSubject.Border.Class = "TextBoxBorder";
            this.tbxSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSubject.Location = new System.Drawing.Point(80, 12);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(612, 21);
            this.tbxSubject.TabIndex = 2;
            this.tbxSubject.TextChanged += new System.EventHandler(this.tbxSubject_TextChanged);
            // 
            // tbxLocation
            // 
            // 
            // 
            // 
            this.tbxLocation.Border.Class = "TextBoxBorder";
            this.tbxLocation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxLocation.Location = new System.Drawing.Point(80, 39);
            this.tbxLocation.Name = "tbxLocation";
            this.tbxLocation.Size = new System.Drawing.Size(612, 21);
            this.tbxLocation.TabIndex = 2;
            // 
            // dateTimeInputStart
            // 
            // 
            // 
            // 
            this.dateTimeInputStart.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputStart.ButtonDropDown.Visible = true;
            this.dateTimeInputStart.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimeInputStart.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.dateTimeInputStart.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputStart.IsPopupCalendarOpen = false;
            this.dateTimeInputStart.Location = new System.Drawing.Point(80, 70);
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputStart.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.DayClickAutoClosePopup = false;
            this.dateTimeInputStart.MonthCalendar.DisplayMonth = new System.DateTime(2012, 12, 1, 0, 0, 0, 0);
            this.dateTimeInputStart.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInputStart.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputStart.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInputStart.Name = "dateTimeInputStart";
            this.dateTimeInputStart.Size = new System.Drawing.Size(322, 21);
            this.dateTimeInputStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputStart.TabIndex = 3;
            this.dateTimeInputStart.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // dateTimeInputEnd
            // 
            // 
            // 
            // 
            this.dateTimeInputEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputEnd.ButtonDropDown.Visible = true;
            this.dateTimeInputEnd.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimeInputEnd.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.dateTimeInputEnd.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputEnd.IsPopupCalendarOpen = false;
            this.dateTimeInputEnd.Location = new System.Drawing.Point(80, 99);
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.MonthCalendar.DayClickAutoClosePopup = false;
            this.dateTimeInputEnd.MonthCalendar.DisplayMonth = new System.DateTime(2012, 12, 1, 0, 0, 0, 0);
            this.dateTimeInputEnd.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInputEnd.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputEnd.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInputEnd.Name = "dateTimeInputEnd";
            this.dateTimeInputEnd.Size = new System.Drawing.Size(322, 21);
            this.dateTimeInputEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputEnd.TabIndex = 3;
            this.dateTimeInputEnd.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // btnxOk
            // 
            this.btnxOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxOk.Command = this.buttonCommand;
            this.btnxOk.CommandParameter = "save";
            this.btnxOk.Location = new System.Drawing.Point(13, 295);
            this.btnxOk.Name = "btnxOk";
            this.btnxOk.Size = new System.Drawing.Size(120, 30);
            this.btnxOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxOk.TabIndex = 4;
            this.btnxOk.Text = "保存";
            // 
            // btnxCancel
            // 
            this.btnxCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxCancel.Command = this.buttonCommand;
            this.btnxCancel.CommandParameter = "cancel";
            this.btnxCancel.Location = new System.Drawing.Point(139, 295);
            this.btnxCancel.Name = "btnxCancel";
            this.btnxCancel.Size = new System.Drawing.Size(120, 30);
            this.btnxCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxCancel.TabIndex = 5;
            this.btnxCancel.Text = "取消";
            // 
            // buttonCommand
            // 
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Executed += new System.EventHandler(this.buttonCommand_Executed);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 336);
            this.Controls.Add(this.btnxCancel);
            this.Controls.Add(this.btnxOk);
            this.Controls.Add(this.dateTimeInputEnd);
            this.Controls.Add(this.dateTimeInputStart);
            this.Controls.Add(this.tbxLocation);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.richTextBoxEx1);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "未命名 -- 约会";
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxSubject;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxLocation;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputStart;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputEnd;
        private DevComponents.DotNetBar.ButtonX btnxOk;
        private DevComponents.DotNetBar.ButtonX btnxCancel;
        private DevComponents.DotNetBar.Command buttonCommand;
    }
}