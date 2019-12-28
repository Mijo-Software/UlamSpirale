using System;
using System.Windows.Forms;

namespace UlamSpirale
{
	public partial class MainForm : Form
	{
		private int prime;
		private int min;
		private int max;

		public MainForm() => InitializeComponent();

		private void ButtonRun_Click(object sender, EventArgs e)
		{
			min = (int)numericUpDownMin.Value;
			max = (int)numericUpDownMax.Value;
			prime = 0;
			/*
			progressBarRun.Style = ProgressBarStyle.Marquee;
			progressBarRun.Enabled = true;
			progressBarRun.Value = 0;
			progressBarRun.Maximum = max;
			*/
			buttonRun.Text = "Wait...";
			buttonRun.Enabled = false;
			backgroundWorker.RunWorkerAsync();
		}

		private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			for (int i = min; i <= max; i++)
			{
				backgroundWorker.ReportProgress(percentProgress: i);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			progressBarRun.Enabled = false;
		}

		private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			buttonRun.Text = "Run";
			buttonRun.Enabled = true;
			progressBarRun.Enabled = false;
			string outp = "Anzahl der Primzahlen: " + prime.ToString() + Environment.NewLine;
			outp = outp + "Geprüfte Zahlen: " + max.ToString() + Environment.NewLine;
			float primicity = prime * 100 / max;
			outp = outp + "Primizität: " + primicity.ToString() + Environment.NewLine;
			MessageBox.Show(outp);
		}

		private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			//progressBarRun.PerformStep();
			if (PrimTool.IsPrime(candidate: e.ProgressPercentage))
			{
				prime++;
			}
		}
	}
}
