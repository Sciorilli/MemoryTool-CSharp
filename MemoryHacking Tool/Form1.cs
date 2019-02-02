using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryHacking_Tool
{
	public partial class MainForm : Form
	{
		//utils
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		static DotNetScanMemory_SmoLL dot = new DotNetScanMemory_SmoLL();
		static IntPtr[] lista;

		public MainForm()
		{
			InitializeComponent();
		}

		private void closelbl_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		//dll work
		
		private void Change_Click(object sender, EventArgs e)
		{
			try
			{
				//change values
				lista = dot.ScanArray(dot.GetPID(processName.Text), ByteValue.Text);
				adresses.Text = processName.Text + " "+ lista.ToString();
				for (int i = 0; i < lista.Count<IntPtr>(); i++)
				{
					dot.WriteArray(lista[i], HexArray.Text);
					adresses.Text = "--Finish--"; 
				}
			}
			catch
			{
				MessageBox.Show("Error - Try another hex array/Process");

			}
		}

		private void ConvertBtn_Click(object sender, EventArgs e)
		{
			try
			{
				byte[] bytes = BitConverter.GetBytes(Convert.ToDouble(ByteConverter.Text));
				string result = BitConverter.ToString(bytes).Replace("-", " ");
				textBoxConverter.Text = "Hex Array: " + result.ToString();
				Clipboard.SetText(result.ToString());

			}
			catch
			{
				MessageBox.Show("Invalid value to convert (double)");
			}
			

		}

		private void info_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/Sciorilli/");
		}

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			//move form
			try
			{
				if (e.Button == MouseButtons.Left)
				{
					ReleaseCapture();
					SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
				}
			}
			catch
			{

			}

		}

		private void label1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
