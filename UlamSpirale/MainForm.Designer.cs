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
			this.colorDialogPrime = new System.Windows.Forms.ColorDialog();
			this.colorDialogNotPrime = new System.Windows.Forms.ColorDialog();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBarRun = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.toolStripControl = new System.Windows.Forms.ToolStrip();
			this.toolStripLabelMinValue = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxMinValue = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabelMaxValue = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxMaxValue = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSplitButtonPrimeColor = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripSplitButtonNotPrimeColor = new System.Windows.Forms.ToolStripSplitButton();
			this.colorDialogError = new System.Windows.Forms.ColorDialog();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.toolStripControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelCanvas
			// 
			this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCanvas.Location = new System.Drawing.Point(0, 0);
			this.panelCanvas.Name = "panelCanvas";
			this.panelCanvas.Size = new System.Drawing.Size(731, 322);
			this.panelCanvas.TabIndex = 0;
			this.panelCanvas.SizeChanged += new System.EventHandler(this.PanelCanvas_SizeChanged);
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
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInformation,
            this.toolStripProgressBarRun});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(731, 22);
			this.statusStrip.TabIndex = 7;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabelInformation
			// 
			this.toolStripStatusLabelInformation.AutoToolTip = true;
			this.toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			this.toolStripStatusLabelInformation.Size = new System.Drawing.Size(93, 17);
			this.toolStripStatusLabelInformation.Text = "Information text";
			// 
			// toolStripProgressBarRun
			// 
			this.toolStripProgressBarRun.AutoToolTip = true;
			this.toolStripProgressBarRun.Name = "toolStripProgressBarRun";
			this.toolStripProgressBarRun.Size = new System.Drawing.Size(100, 16);
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
			this.toolStripContainer1.ContentPanel.Controls.Add(this.panelCanvas);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(731, 322);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(731, 369);
			this.toolStripContainer1.TabIndex = 8;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripControl);
			// 
			// toolStripControl
			// 
			this.toolStripControl.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripControl.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelMinValue,
            this.toolStripTextBoxMinValue,
            this.toolStripLabelMaxValue,
            this.toolStripTextBoxMaxValue,
            this.toolStripButtonRun,
            this.toolStripSeparator1,
            this.toolStripSplitButtonPrimeColor,
            this.toolStripSplitButtonNotPrimeColor});
			this.toolStripControl.Location = new System.Drawing.Point(3, 0);
			this.toolStripControl.Name = "toolStripControl";
			this.toolStripControl.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStripControl.Size = new System.Drawing.Size(570, 25);
			this.toolStripControl.TabIndex = 0;
			this.toolStripControl.TabStop = true;
			this.toolStripControl.Text = "toolStripControl";
			// 
			// toolStripLabelMinValue
			// 
			this.toolStripLabelMinValue.Name = "toolStripLabelMinValue";
			this.toolStripLabelMinValue.Size = new System.Drawing.Size(34, 22);
			this.toolStripLabelMinValue.Text = "Min.:";
			// 
			// toolStripTextBoxMinValue
			// 
			this.toolStripTextBoxMinValue.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripTextBoxMinValue.Name = "toolStripTextBoxMinValue";
			this.toolStripTextBoxMinValue.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxMinValue.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolStripTextBoxMinValue.TextChanged += new System.EventHandler(this.ToolStripTextBoxMinValue_TextChanged);
			// 
			// toolStripLabelMaxValue
			// 
			this.toolStripLabelMaxValue.Name = "toolStripLabelMaxValue";
			this.toolStripLabelMaxValue.Size = new System.Drawing.Size(36, 22);
			this.toolStripLabelMaxValue.Text = "Max.:";
			// 
			// toolStripTextBoxMaxValue
			// 
			this.toolStripTextBoxMaxValue.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripTextBoxMaxValue.Name = "toolStripTextBoxMaxValue";
			this.toolStripTextBoxMaxValue.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxMaxValue.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolStripTextBoxMaxValue.TextChanged += new System.EventHandler(this.ToolStripTextBoxMaxValue_TextChanged);
			// 
			// toolStripButtonRun
			// 
			this.toolStripButtonRun.Image = global::UlamSpirale.Properties.Resources.fatcow_control_16;
			this.toolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRun.Name = "toolStripButtonRun";
			this.toolStripButtonRun.Size = new System.Drawing.Size(51, 22);
			this.toolStripButtonRun.Text = "Run!";
			this.toolStripButtonRun.Click += new System.EventHandler(this.ToolStripButtonRun_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSplitButtonPrimeColor
			// 
			this.toolStripSplitButtonPrimeColor.Image = global::UlamSpirale.Properties.Resources.fatcow_color_wheel_16;
			this.toolStripSplitButtonPrimeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonPrimeColor.Name = "toolStripSplitButtonPrimeColor";
			this.toolStripSplitButtonPrimeColor.Size = new System.Drawing.Size(102, 22);
			this.toolStripSplitButtonPrimeColor.Text = "Prime Color";
			this.toolStripSplitButtonPrimeColor.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonPrimeColor_ButtonClick);
			// 
			// toolStripSplitButtonNotPrimeColor
			// 
			this.toolStripSplitButtonNotPrimeColor.Image = global::UlamSpirale.Properties.Resources.fatcow_color_wheel_16;
			this.toolStripSplitButtonNotPrimeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonNotPrimeColor.Name = "toolStripSplitButtonNotPrimeColor";
			this.toolStripSplitButtonNotPrimeColor.Size = new System.Drawing.Size(125, 22);
			this.toolStripSplitButtonNotPrimeColor.Text = "Not Prime Color";
			this.toolStripSplitButtonNotPrimeColor.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonNotPrimeColor_ButtonClick);
			// 
			// colorDialogError
			// 
			this.colorDialogError.Color = System.Drawing.Color.Red;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 369);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UlamSpirale";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.toolStripControl.ResumeLayout(false);
			this.toolStripControl.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.ColorDialog colorDialogPrime;
        private System.Windows.Forms.ColorDialog colorDialogNotPrime;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ColorDialog colorDialogError;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInformation;
		private System.Windows.Forms.ToolStrip toolStripControl;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMinValue;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMaxValue;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarRun;
		private System.Windows.Forms.ToolStripLabel toolStripLabelMinValue;
		private System.Windows.Forms.ToolStripLabel toolStripLabelMaxValue;
		private System.Windows.Forms.ToolStripButton toolStripButtonRun;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonPrimeColor;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonNotPrimeColor;
	}
}

