using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UlamSpirale
{
	public partial class MainForm : Form
	{
		private int prime;
		private int min;
		private int max;
		private int x;
		private int y;
		private Graphics graphics;
		private readonly SolidBrush brushNotPrime = new SolidBrush(Color.Black);
		private readonly SolidBrush brushPrime = new SolidBrush(Color.Red);

		public MainForm() => InitializeComponent();

		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			/*bmpSave = new Bitmap(panelDraw.Width, panelDraw.Height);
			graphics = Graphics.FromImage(bmpSave);
			panelDraw.Image = bmpSave;*/
			for (int i = min; i <= max; i++)
			{
				backgroundWorker.ReportProgress(percentProgress: i);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			toolStripTextBoxMinValue.Text = "1";
			toolStripTextBoxMaxValue.Text = (panelCanvas.Width * panelCanvas.Height).ToString();
			graphics = panelCanvas.CreateGraphics();
			//progressBarRun.Enabled = false;
		}

		private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			toolStripButtonRun.Text = "Run";
			toolStripButtonRun.Enabled = true;
			//progressBarRun.Enabled = false;
			string outp = "Anzahl der Primzahlen: " + prime.ToString() + Environment.NewLine;
			outp = outp + "Geprüfte Zahlen: " + max.ToString() + Environment.NewLine;
			float primicity = prime * 100 / max;
			outp = outp + "Primizität: " + primicity.ToString() + Environment.NewLine;
			MessageBox.Show(outp);
		}

		private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			//progressBarRun.PerformStep();
			y++;
			if (y > panelCanvas.Height)
			{
				y = 0;
				x++;
			}
			if (PrimTool.IsPrime(candidate: e.ProgressPercentage))
			{
				prime++;
				graphics.FillRectangle(brush: brushPrime, x: x, y: y, width: 1, height: 1);
			}
			else
			{
				graphics.FillRectangle(brush: brushNotPrime, x: x, y: y, width: 1, height: 1);
				//graphics.FillRectangle(brush: brushNotPrime, x: panelCanvas.Width + x, y: panelCanvas.Height + y, width: 1, height: 1);
			}
		}

		private void ToolStripSplitButtonPrimeColor_ButtonClick(object sender, EventArgs e)
		{
			if (colorDialogPrime.ShowDialog() == DialogResult.OK)
			{
				brushPrime.Color = colorDialogPrime.Color;
			}
		}

		private void ToolStripSplitButtonNotPrimeColor_ButtonClick(object sender, EventArgs e)
		{
			if (colorDialogNotPrime.ShowDialog() == DialogResult.OK)
			{
				brushNotPrime.Color = colorDialogNotPrime.Color;
			}
		}

		private void ToolStripButtonRun_Click(object sender, EventArgs e)
		{
			graphics.Clear(color: panelCanvas.BackColor);
			x = 0;
			y = 0;
			min = Int32.Parse(toolStripTextBoxMinValue.Text);
			max = Int32.Parse(toolStripTextBoxMaxValue.Text);
			prime = 0;
			/*
			progressBarRun.Style = ProgressBarStyle.Marquee;
			progressBarRun.Enabled = true;
			progressBarRun.Value = 0;
			progressBarRun.Maximum = max;
			*/
			toolStripButtonRun.Text = "Wait...";
			toolStripButtonRun.Enabled = false;
			backgroundWorker.RunWorkerAsync();
		}

		private void ToolStripTextBoxMinValue_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(toolStripTextBoxMinValue.Text, "[^0-9]"))
			{
				MessageBox.Show("Please enter only numbers.");
				//toolStripTextBoxMinValue.Text = toolStripTextBoxMinValue.Text.Remove(toolStripTextBoxMinValue.Text.Length - 1);
			}
		}

		private void ToolStripTextBoxMaxValue_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(toolStripTextBoxMaxValue.Text, "[^0-9]"))
			{
				MessageBox.Show("Please enter only numbers.");
				//toolStripTextBoxMaxValue.Text = toolStripTextBoxMaxValue.Text.Remove(toolStripTextBoxMaxValue.Text.Length - 1);
			}
		}

		private void PanelCanvas_SizeChanged(object sender, EventArgs e)
		{
			toolStripTextBoxMaxValue.Text = (panelCanvas.Width * panelCanvas.Height).ToString();
		}
	}
}
