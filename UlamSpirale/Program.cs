using System;
using System.Windows.Forms;

namespace UlamSpirale
{
	/// <summary>
	/// Program
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (MainForm mainForm = new MainForm())
			{
				Application.Run(mainForm: mainForm);
			}
		}
	}
}
