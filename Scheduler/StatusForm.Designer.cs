namespace Scheduler
{
    partial class StatusForm
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
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale4 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer4 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeRange gaugeRange2 = new DevComponents.Instrumentation.GaugeRange();
            DevComponents.Instrumentation.GaugeSection gaugeSection4 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor7 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor8 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText3 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale5 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor9 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor10 = new DevComponents.Instrumentation.GradientFillColor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            DevComponents.Instrumentation.GaugePointer gaugePointer5 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection5 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale6 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer6 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection6 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor11 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor12 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText4 = new DevComponents.Instrumentation.GaugeText();
            this.gaugeControl1 = new DevComponents.Instrumentation.GaugeControl();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.gaugeControl2 = new DevComponents.Instrumentation.GaugeControl();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            gaugeCircularScale4.MaxPin.Name = "MaxPin";
            gaugeCircularScale4.MinPin.Name = "MinPin";
            gaugeCircularScale4.Name = "Scale1";
            gaugePointer4.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer4.CapFillColor.BorderWidth = 1;
            gaugePointer4.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer4.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer4.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer4.FillColor.BorderWidth = 1;
            gaugePointer4.FillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer4.FillColor.Color2 = System.Drawing.Color.Red;
            gaugePointer4.Length = 0.358F;
            gaugePointer4.Name = "Pointer1";
            gaugePointer4.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugeCircularScale4.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer4});
            gaugeRange2.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugeRange2.FillColor.BorderWidth = 1;
            gaugeRange2.FillColor.Color1 = System.Drawing.Color.Lime;
            gaugeRange2.FillColor.Color2 = System.Drawing.Color.Red;
            gaugeRange2.Name = "Range1";
            gaugeRange2.ScaleOffset = 0.28F;
            gaugeRange2.StartValue = 70D;
            gaugeCircularScale4.Ranges.AddRange(new DevComponents.Instrumentation.GaugeRange[] {
            gaugeRange2});
            gaugeSection4.FillColor.Color1 = System.Drawing.Color.CornflowerBlue;
            gaugeSection4.FillColor.Color2 = System.Drawing.Color.Purple;
            gaugeSection4.Name = "Section1";
            gaugeCircularScale4.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection4});
            this.gaugeControl1.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale4});
            gradientFillColor7.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor7.Color2 = System.Drawing.Color.DarkGray;
            this.gaugeControl1.Frame.BackColor = gradientFillColor7;
            gradientFillColor8.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor8.BorderWidth = 1;
            gradientFillColor8.Color1 = System.Drawing.Color.White;
            gradientFillColor8.Color2 = System.Drawing.Color.DimGray;
            this.gaugeControl1.Frame.FrameColor = gradientFillColor8;
            this.gaugeControl1.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            gaugeText3.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText3.Font = new System.Drawing.Font("浪漫雅圆", 15F, System.Drawing.FontStyle.Bold);
            gaugeText3.Name = "Text1";
            gaugeText3.Text = "CPU";
            gaugeText3.Tooltip = "CPU使用率";
            this.gaugeControl1.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText3});
            this.gaugeControl1.Location = new System.Drawing.Point(12, 12);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(250, 250);
            this.gaugeControl1.TabIndex = 0;
            this.gaugeControl1.Text = "gaugeControl1";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 281);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(250, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "CPU使用率";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(327, 281);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(250, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "内存占用率";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // gaugeControl2
            // 
            gaugeCircularScale5.Labels.Layout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            gaugeCircularScale5.Labels.Layout.RotateLabel = false;
            gaugeCircularScale5.MajorTickMarks.Interval = 1D;
            gradientFillColor9.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor9.BorderWidth = 1;
            gradientFillColor9.Color1 = System.Drawing.Color.White;
            gaugeCircularScale5.MajorTickMarks.Layout.FillColor = gradientFillColor9;
            gaugeCircularScale5.MajorTickMarks.Layout.Length = 0.263F;
            gaugeCircularScale5.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Circle;
            gaugeCircularScale5.MajorTickMarks.Layout.Width = 0.263F;
            gaugeCircularScale5.MaxPin.Name = "MaxPin";
            gaugeCircularScale5.MaxValue = 10D;
            gaugeCircularScale5.MinorTickMarks.Interval = 0.5D;
            gradientFillColor10.Color1 = System.Drawing.Color.Black;
            gaugeCircularScale5.MinorTickMarks.Layout.FillColor = gradientFillColor10;
            gaugeCircularScale5.MinorTickMarks.Layout.Length = 0.2F;
            gaugeCircularScale5.MinPin.Name = "MinPin";
            gaugeCircularScale5.Name = "Scale1";
            gaugeCircularScale5.PivotPoint = ((System.Drawing.PointF)(resources.GetObject("gaugeCircularScale5.PivotPoint")));
            gaugePointer5.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer5.CapFillColor.BorderWidth = 1;
            gaugePointer5.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer5.CapFillColor.Color2 = System.Drawing.Color.Brown;
            gaugePointer5.CapFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center;
            gaugePointer5.CapStyle = DevComponents.Instrumentation.NeedlePointerCapStyle.Style1;
            gaugePointer5.CapWidth = 0.4F;
            gaugePointer5.FillColor.BorderColor = System.Drawing.Color.DarkSlateGray;
            gaugePointer5.FillColor.BorderWidth = 1;
            gaugePointer5.FillColor.Color1 = System.Drawing.Color.Turquoise;
            gaugePointer5.Length = 0.54F;
            gaugePointer5.Name = "Pointer1";
            gaugePointer5.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style6;
            gaugePointer5.Placement = DevComponents.Instrumentation.DisplayPlacement.Near;
            gaugePointer5.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer5.Width = 0.2F;
            gaugeCircularScale5.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer5});
            gaugeCircularScale5.Radius = 0.092F;
            gaugeSection5.FillColor.Color1 = System.Drawing.Color.CornflowerBlue;
            gaugeSection5.Name = "Section1";
            gaugeCircularScale5.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection5});
            gaugeCircularScale5.Width = 0.139F;
            gaugeCircularScale6.MaxPin.Name = "MaxPin";
            gaugeCircularScale6.MinPin.Name = "MinPin";
            gaugeCircularScale6.Name = "Scale2";
            gaugePointer6.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer6.CapFillColor.BorderWidth = 1;
            gaugePointer6.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer6.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer6.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer6.FillColor.BorderWidth = 1;
            gaugePointer6.FillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer6.FillColor.Color2 = System.Drawing.Color.Red;
            gaugePointer6.Length = 0.358F;
            gaugePointer6.Name = "Pointer1";
            gaugePointer6.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugeCircularScale6.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer6});
            gaugeSection6.FillColor.Color1 = System.Drawing.Color.CornflowerBlue;
            gaugeSection6.FillColor.Color2 = System.Drawing.Color.Purple;
            gaugeSection6.Name = "Section1";
            gaugeCircularScale6.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection6});
            this.gaugeControl2.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale5,
            gaugeCircularScale6});
            gradientFillColor11.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor11.Color2 = System.Drawing.Color.DarkGray;
            this.gaugeControl2.Frame.BackColor = gradientFillColor11;
            gradientFillColor12.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor12.BorderWidth = 1;
            gradientFillColor12.Color1 = System.Drawing.Color.White;
            gradientFillColor12.Color2 = System.Drawing.Color.DimGray;
            this.gaugeControl2.Frame.FrameColor = gradientFillColor12;
            this.gaugeControl2.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            gaugeText4.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText4.Font = new System.Drawing.Font("浪漫雅圆", 15F, System.Drawing.FontStyle.Bold);
            gaugeText4.Name = "Text1";
            gaugeText4.Text = "RAM";
            gaugeText4.Tooltip = "内存占用率";
            this.gaugeControl2.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText4});
            this.gaugeControl2.Location = new System.Drawing.Point(327, 12);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(250, 250);
            this.gaugeControl2.TabIndex = 4;
            this.gaugeControl2.Text = "gaugeControl2";
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 350);
            this.Controls.Add(this.gaugeControl2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.gaugeControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Instrumentation.GaugeControl gaugeControl1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Instrumentation.GaugeControl gaugeControl2;
    }
}