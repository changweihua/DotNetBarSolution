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
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale1 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer1 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeRange gaugeRange1 = new DevComponents.Instrumentation.GaugeRange();
            DevComponents.Instrumentation.GaugeSection gaugeSection1 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor1 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor2 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText1 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale2 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GaugePointer gaugePointer2 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection2 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor3 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor4 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText2 = new DevComponents.Instrumentation.GaugeText();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            this.gcCPU = new DevComponents.Instrumentation.GaugeControl();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.gcRAM = new DevComponents.Instrumentation.GaugeControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCPU
            // 
            gaugeCircularScale1.MaxPin.Name = "MaxPin";
            gaugeCircularScale1.MinPin.Name = "MinPin";
            gaugeCircularScale1.Name = "Scale1";
            gaugePointer1.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer1.CapFillColor.BorderWidth = 1;
            gaugePointer1.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer1.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer1.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer1.FillColor.BorderWidth = 1;
            gaugePointer1.FillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer1.FillColor.Color2 = System.Drawing.Color.Red;
            gaugePointer1.Length = 0.358F;
            gaugePointer1.Name = "Pointer1";
            gaugePointer1.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugeCircularScale1.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer1});
            gaugeRange1.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugeRange1.FillColor.BorderWidth = 1;
            gaugeRange1.FillColor.Color1 = System.Drawing.Color.Lime;
            gaugeRange1.FillColor.Color2 = System.Drawing.Color.Red;
            gaugeRange1.Name = "Range1";
            gaugeRange1.ScaleOffset = 0.28F;
            gaugeRange1.StartValue = 70D;
            gaugeCircularScale1.Ranges.AddRange(new DevComponents.Instrumentation.GaugeRange[] {
            gaugeRange1});
            gaugeSection1.FillColor.Color1 = System.Drawing.Color.CornflowerBlue;
            gaugeSection1.FillColor.Color2 = System.Drawing.Color.Purple;
            gaugeSection1.Name = "Section1";
            gaugeCircularScale1.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection1});
            this.gcCPU.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale1});
            gradientFillColor1.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor1.Color2 = System.Drawing.Color.DarkGray;
            this.gcCPU.Frame.BackColor = gradientFillColor1;
            gradientFillColor2.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor2.BorderWidth = 1;
            gradientFillColor2.Color1 = System.Drawing.Color.White;
            gradientFillColor2.Color2 = System.Drawing.Color.DimGray;
            this.gcCPU.Frame.FrameColor = gradientFillColor2;
            gaugeText1.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText1.Font = new System.Drawing.Font("浪漫雅圆", 15F, System.Drawing.FontStyle.Bold);
            gaugeText1.Name = "Text1";
            gaugeText1.Text = "CPU";
            gaugeText1.Tooltip = "CPU使用率";
            this.gcCPU.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText1});
            this.gcCPU.Location = new System.Drawing.Point(12, 12);
            this.gcCPU.Name = "gcCPU";
            this.gcCPU.Size = new System.Drawing.Size(250, 250);
            this.gcCPU.TabIndex = 0;
            this.gcCPU.Text = "gaugeControl1";
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
            // gcRAM
            // 
            gaugeCircularScale2.MaxPin.Name = "MaxPin";
            gaugeCircularScale2.MinPin.Name = "MinPin";
            gaugeCircularScale2.Name = "Scale2";
            gaugePointer2.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer2.CapFillColor.BorderWidth = 1;
            gaugePointer2.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer2.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer2.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer2.FillColor.BorderWidth = 1;
            gaugePointer2.FillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer2.FillColor.Color2 = System.Drawing.Color.Red;
            gaugePointer2.Length = 0.358F;
            gaugePointer2.Name = "Pointer1";
            gaugePointer2.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugeCircularScale2.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer2});
            gaugeSection2.FillColor.Color1 = System.Drawing.Color.CornflowerBlue;
            gaugeSection2.FillColor.Color2 = System.Drawing.Color.Purple;
            gaugeSection2.Name = "Section1";
            gaugeCircularScale2.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection2});
            this.gcRAM.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale2});
            this.gcRAM.Frame.AddGlassEffect = true;
            gradientFillColor3.Color1 = System.Drawing.Color.Gainsboro;
            gradientFillColor3.Color2 = System.Drawing.Color.DarkGray;
            this.gcRAM.Frame.BackColor = gradientFillColor3;
            gradientFillColor4.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor4.BorderWidth = 1;
            gradientFillColor4.Color1 = System.Drawing.Color.White;
            gradientFillColor4.Color2 = System.Drawing.Color.DimGray;
            this.gcRAM.Frame.FrameColor = gradientFillColor4;
            gaugeText2.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText2.Font = new System.Drawing.Font("浪漫雅圆", 15F, System.Drawing.FontStyle.Bold);
            gaugeText2.Name = "Text1";
            gaugeText2.Text = "RAM";
            gaugeText2.Tooltip = "内存占用率";
            this.gcRAM.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText2});
            this.gcRAM.Location = new System.Drawing.Point(327, 12);
            this.gcRAM.Name = "gcRAM";
            this.gcRAM.Size = new System.Drawing.Size(250, 250);
            this.gcRAM.TabIndex = 4;
            this.gcRAM.Text = "gaugeControl2";
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.Controls.Add(this.gcRAM);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.gcCPU);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "运行状态";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Instrumentation.GaugeControl gcCPU;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Instrumentation.GaugeControl gcRAM;
    }
}