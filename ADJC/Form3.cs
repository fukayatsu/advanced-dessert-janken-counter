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
	public partial class Form3 : Form
	{

		public Form1 form1;
		
		public Form3()
		{
			InitializeComponent();


			string line = Form1.z_line;

			string[] cell = line.Split(',');

			label2.Text = cell[0];
			label4.Text = cell[2];
			label5.Text= "支払い額：\\"+cell[1];

			label6.Text = "+ \\" + (int.Parse(cell[1]) / int.Parse(cell[3])).ToString();
			label7.Text = "- \\" + (int.Parse(cell[1]) - int.Parse(cell[1]) / int.Parse(cell[3])).ToString();
			label8.Text = "×" + (int.Parse(cell[3])-1).ToString() + "人";
			for (int i = 4; i < cell.Length-1; i++) {
				listBox1.Items.Add(cell[i]);
			}
			label9.Text = cell[cell.Length-1];
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			button1.Select();
		}

		

		private void Form3_KeyUp(object sender, KeyEventArgs e)
		{
		
		}
	}
}
