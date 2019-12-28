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
			this.components = new System.ComponentModel.Container();
			this.panelCanvas = new System.Windows.Forms.Panel();
			this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
			this.buttonRun = new System.Windows.Forms.Button();
			this.progressBarRun = new System.Windows.Forms.ProgressBar();
			this.colorDialogPrime = new System.Windows.Forms.ColorDialog();
			this.colorDialogNotPrime = new System.Windows.Forms.ColorDialog();
			this.buttonPrimeColor = new System.Windows.Forms.Button();
			this.buttonNotPrimeColor = new System.Windows.Forms.Button();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.buttonErrorColor = new System.Windows.Forms.Button();
			this.colorDialogErrorColor = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelCanvas
			// 
			this.panelCanvas.BackColor = System.Drawing.Color.White;
			this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCanvas.Location = new System.Drawing.Point(12, 94);
			this.panelCanvas.Name = "panelCanvas";
			this.panelCanvas.Size = new System.Drawing.Size(245, 193);
			this.panelCanvas.TabIndex = 0;
			// 
			// numericUpDownMin
			// 
			this.numericUpDownMin.Location = new System.Drawing.Point(12, 12);
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
			this.numericUpDownMax.Location = new System.Drawing.Point(97, 12);
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
			this.buttonRun.Location = new System.Drawing.Point(182, 12);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(75, 20);
			this.buttonRun.TabIndex = 3;
			this.buttonRun.Text = "Run";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
			// 
			// progressBarRun
			// 
			this.progressBarRun.Enabled = false;
			this.progressBarRun.Location = new System.Drawing.Point(12, 39);
			this.progressBarRun.MarqueeAnimationSpeed = 10;
			this.progressBarRun.Name = "progressBarRun";
			this.progressBarRun.Size = new System.Drawing.Size(245, 23);
			this.progressBarRun.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarRun.TabIndex = 4;
			// 
			// colorDialogPrime
			// 
			this.colorDialogPrime.AnyColor = true;
			this.colorDialogPrime.Color = System.Drawing.Color.White;
			// 
			// colorDialogNotPrime
			// 
			this.colorDialogNotPrime.AnyColor = true;
			// 
			// buttonPrimeColor
			// 
			this.buttonPrimeColor.Location = new System.Drawing.Point(12, 68);
			this.buttonPrimeColor.Name = "buttonPrimeColor";
			this.buttonPrimeColor.Size = new System.Drawing.Size(68, 20);
			this.buttonPrimeColor.TabIndex = 5;
			this.buttonPrimeColor.Text = "Prime Color";
			this.buttonPrimeColor.UseVisualStyleBackColor = true;
			// 
			// buttonNotPrimeColor
			// 
			this.buttonNotPrimeColor.Location = new System.Drawing.Point(86, 68);
			this.buttonNotPrimeColor.Name = "buttonNotPrimeColor";
			this.buttonNotPrimeColor.Size = new System.Drawing.Size(90, 20);
			this.buttonNotPrimeColor.TabIndex = 6;
			this.buttonNotPrimeColor.Text = "Not Prime Color";
			this.buttonNotPrimeColor.UseVisualStyleBackColor = true;
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(269, 22);
			this.statusStrip.TabIndex = 7;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonErrorColor);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonNotPrimeColor);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonPrimeColor);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.progressBarRun);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonRun);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.numericUpDownMax);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.numericUpDownMin);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.panelCanvas);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(269, 304);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(269, 326);
			this.toolStripContainer1.TabIndex = 8;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// buttonErrorColor
			// 
			this.buttonErrorColor.Location = new System.Drawing.Point(182, 68);
			this.buttonErrorColor.Name = "buttonErrorColor";
			this.buttonErrorColor.Size = new System.Drawing.Size(75, 20);
			this.buttonErrorColor.TabIndex = 8;
			this.buttonErrorColor.Text = "Error Color";
			this.buttonErrorColor.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 326);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ulam-Spirale";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelCanvas;
    private System.Windows.Forms.NumericUpDown numericUpDownMin;
    private System.Windows.Forms.NumericUpDown numericUpDownMax;
    private System.Windows.Forms.Button buttonRun;
    private System.Windows.Forms.ProgressBar progressBarRun;
        private System.Windows.Forms.ColorDialog colorDialogPrime;
        private System.Windows.Forms.ColorDialog colorDialogNotPrime;
        private System.Windows.Forms.Button buttonPrimeColor;
        private System.Windows.Forms.Button buttonNotPrimeColor;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button buttonErrorColor;
        private System.Windows.Forms.ColorDialog colorDialogErrorColor;
    }
}

