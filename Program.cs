using System;
using System.Windows.Forms;

namespace LOIC
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			Application.Run(new atlaspanel());
		}
	}
}
