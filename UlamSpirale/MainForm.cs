using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UlamSpirale
{
  public partial class MainForm : Form
  {
    int min = 0, max = 0;

    public MainForm()
    {
      InitializeComponent();
    }

    private void buttonRun_Click(object sender, EventArgs e)
    {
      min = (int)numericUpDownMin.Value;
      max = (int)numericUpDownMax.Value;
      progressBarRun.Enabled = true;
      progressBarRun.Value = 0;
      progressBarRun.Maximum = max;
      int prim = 0;
      for (int i = min; i < max+1; i++)
      {
        if (PrimTool.IsPrime(i)) prim++;
        progressBarRun.Value = i;       
      }
      progressBarRun.Enabled = false;
      string outp = "Anzahl der Primzahlen: " + prim.ToString() + Environment.NewLine;
      outp = outp + "Geprüfte Zahlen: " + max.ToString() + Environment.NewLine;
      float primicity = prim * 100 / max;
      outp = outp + "Primizität: " + primicity.ToString() + Environment.NewLine;
      MessageBox.Show(outp);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      progressBarRun.Enabled = false;
    }
  }
}
