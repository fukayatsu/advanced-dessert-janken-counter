using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace ADJC
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			System.Reflection.Assembly myAssenbly =
				System.Reflection.Assembly.GetExecutingAssembly();

			System.IO.StreamReader sr =
				new StreamReader(myAssenbly.GetManifestResourceStream("ADJC.TextFile1.txt"),
					System.Text.Encoding.GetEncoding("shift-jis"));

			string s = sr.ReadToEnd();
			sr.Close();


			
			richTextBox1.Text = s;
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);

		}
	}
}
