using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ADJC
{
	public partial class Form5 : Form
	{
		[DllImport("AquesTalkDa.dll")]
		private static extern int AquesTalkDa_PlaySync(string koe, int iSpeed);


		public Form5()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			int irt = AquesTalkDa_PlaySync(textBox1.Text, 100);
			if (irt != 0) MessageBox.Show("発声エラー");
		}
	}
}
