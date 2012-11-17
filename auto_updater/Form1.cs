using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace auto_updater
{
	public partial class Form1 : Form
	{
		int t=0;	//0.1秒単位

		public Form1()
		{
			InitializeComponent();
		}

		private void move_file() {
			timer1.Enabled = false;
			
			if (!File.Exists("next_version//ADJC.exe")) {
				Application.Exit();
				return;
			}

			File.Delete("ADJC.exe");
			File.Move("next_version//ADJC.exe", "ADJC.exe");

			timer1.Enabled = true;
		}

		private void run_new() {
			timer1.Enabled = false;

			System.Diagnostics.Process.Start("ADJC.exe");

			timer1.Enabled = true;		
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			progressBar1.Value = t;

			if (t == 30) move_file();
			if (t == 70) run_new();
			
			t++;
			if (t > progressBar1.Maximum) {
				timer1.Enabled = false;
				Application.Exit();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
		}
	}
}
