namespace UlamSpirale
{
  partial class MainForm
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
      this.panelCanvas = new System.Windows.Forms.Panel();
      this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
      this.buttonRun = new System.Windows.Forms.Button();
      this.progressBarRun = new System.Windows.Forms.ProgressBar();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
      this.SuspendLayout();
      // 
      // panelCanvas
      // 
      this.panelCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.panelCanvas.BackColor = System.Drawing.Color.White;
      this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelCanvas.Location = new System.Drawing.Point(191, 243);
      this.panelCanvas.Name = "panelCanvas";
      this.panelCanvas.Size = new System.Drawing.Size(200, 89);
      this.panelCanvas.TabIndex = 0;
      // 
      // numericUpDownMin
      // 
      this.numericUpDownMin.Location = new System.Drawing.Point(28, 40);
      this.numericUpDownMin.Maximum = new decimal(new int[] {
            0,
            -2147483648,
            0,
            0});
      this.numericUpDownMin.Name = "numericUpDownMin";
      this.numericUpDownMin.Size = new System.Drawing.Size(79, 20);
      this.numericUpDownMin.TabIndex = 1;
      this.numericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // numericUpDownMax
      // 
      this.numericUpDownMax.Location = new System.Drawing.Point(113, 40);
      this.numericUpDownMax.Maximum = new decimal(new int[] {
            0,
            -2147483648,
            0,
            0});
      this.numericUpDownMax.Name = "numericUpDownMax";
      this.numericUpDownMax.Size = new System.Drawing.Size(79, 20);
      this.numericUpDownMax.TabIndex = 2;
      this.numericUpDownMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDownMax.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      // 
      // buttonRun
      // 
      this.buttonRun.Location = new System.Drawing.Point(198, 40);
      this.buttonRun.Name = "buttonRun";
      this.buttonRun.Size = new System.Drawing.Size(75, 20);
      this.buttonRun.TabIndex = 3;
      this.buttonRun.Text = "button1";
      this.buttonRun.UseVisualStyleBackColor = true;
      this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
      // 
      // progressBarRun
      // 
      this.progressBarRun.Enabled = false;
      this.progressBarRun.Location = new System.Drawing.Point(28, 67);
      this.progressBarRun.Name = "progressBarRun";
      this.progressBarRun.Size = new System.Drawing.Size(245, 23);
      this.progressBarRun.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBarRun.TabIndex = 4;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(544, 415);
      this.Controls.Add(this.progressBarRun);
      this.Controls.Add(this.buttonRun);
      this.Controls.Add(this.numericUpDownMax);
      this.Controls.Add(this.numericUpDownMin);
      this.Controls.Add(this.panelCanvas);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ulam-Spirale";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelCanvas;
    private System.Windows.Forms.NumericUpDown numericUpDownMin;
    private System.Windows.Forms.NumericUpDown numericUpDownMax;
    private System.Windows.Forms.Button buttonRun;
    private System.Windows.Forms.ProgressBar progressBarRun;
  }
}

