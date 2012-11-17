using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Runtime.InteropServices;
using System.Net;
using System.Web;

using iPentec.TwitterUtils;

namespace ADJC
{
	public partial class Form2 : Form
	{
		[DllImport("AquesTalkDa.dll")]
		private static extern int AquesTalkDa_PlaySync(string koe, int iSpeed);

		struct PersonName {
			public string name,yomi,nickname;
		}
		
		PersonName[] pn = new PersonName[100];

		const string memberfile = "member.txt";
		const string logfile = "log.txt";
		
		public Form2()
		{
			InitializeComponent();
		}

		//twitterにPOSTする関数。 ベーシック認証
		private string PostData(string url, string user,
								string pass, string mes)
		{
			//投稿内容をURLエンコードする
			string encMes = System.Web.HttpUtility.UrlEncode(mes);
			HttpWebRequest request =
				(HttpWebRequest)HttpWebRequest.Create(url);
			request.Method = "POST";
			//認証情報を設定
			request.Credentials = new NetworkCredential(user, pass);
			//Content-typeヘッダを設定
			request.ContentType =
				"application/x-www-form-urlencoded";
			request.UserAgent = "twitter API Tester";
			request.Timeout = 10000;
			//これをしないと417
			System.Net.ServicePointManager.Expect100Continue = false;
			//書き込む
			StreamWriter writer =
				new StreamWriter(request.GetRequestStream());
			writer.Write("status={0}", encMes);
			writer.Close();
			//読み込む
			WebResponse response = request.GetResponse();
			StreamReader reader =
				new StreamReader(response.GetResponseStream());
			string result = reader.ReadToEnd();
			//後処理
			reader.Close();
			response.Close();

			return result;
		}

		//やり直しボタン
		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			listBox2.Items.Clear();
			label4.Text = null;
			label8.Text = null;

			Load_members();

			enable_button();
			
		}
		//メンバー読み込み関数
		private void Load_members() { 
			if (!File.Exists(memberfile)) return;

			StreamReader reader = new StreamReader(memberfile,Encoding.GetEncoding("Shift_JIS"));
			string[] temp;
			listBox1.Items.Clear();
			string line;
			int i = 0;
			while((line=reader.ReadLine()) != null){
				//一行ついての処理
				if (line == "") {
					continue;
				}
				else
				{
					temp = line.Split(',');
					listBox1.Items.Add(temp[0]);

					pn[i].name = temp[0];
					pn[i].yomi = temp[1];
					pn[i].nickname = temp[2];

					i++;
				}
			}
			reader.Close();
		}
		//登録可能か調べる関数
		private void enable_button() {
			//登録ボタン
			if (listBox2.Items.Count > 1 && label4.Text != "")
			{
				button1.Enabled = true;
			}
			else {
				button1.Enabled = false;
			}

			//やり直しボタン
			if (listBox2.Items.Count == 0 && label4.Text == "")
			{
				button2.Enabled = false;
			}
			else {
				button2.Enabled = true;
			}

			//←ボタン
			if (listBox2.SelectedIndex != -1)
			{
				button3.Enabled = true;
			}
			else {
				button3.Enabled = false;
			}
		}

		
		//メンバ→参加者
		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listBox1.Items.Count == 0) return;
			listBox2.Items.Add(listBox1.SelectedItem);
			listBox1.Items.Remove(listBox1.SelectedItem);
			label8.Text = listBox2.Items.Count.ToString();
			


			enable_button();
		}

		//おごってくれた人を表示
		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox2.SelectedIndex == -1) { 
				label4.Text = "";
				enable_button();
				return;
			}
			label4.Text = listBox2.SelectedItem.ToString();
			enable_button();
			try
			{
				string path = "img\\" + listBox2.SelectedItem.ToString() + ".jpg";
				pictureBox1.Image = Image.FromFile(path);
			}
			catch (Exception e3)
			{
				pictureBox1.Image = Image.FromFile("img\\no_image.jpg");
			}
		}

		

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
		}



		//日時、合計金額、敗者、全参加者を記録する。
		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("間違いありませんか？", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				//MessageBox.Show("[はい] ボタンを選択しました");
				//馬鹿にする
				if (checkBox1.Checked) {
				
					//int iret = AquesTalkDa_PlaySync("ざまあー", 100);
					for (int i = 0; i < 100; i++) {
						if (label4.Text == pn[i].name) {
							int irt =AquesTalkDa_PlaySync(pn[i].yomi, 100);
							if (irt != 0) MessageBox.Show("発声エラー");
							break;
						}
					}
				}
			}
			else
			{
				//MessageBox.Show("[いいえ] ボタンを選択しました");
				return;
			}
			int ogori = (int)(numericUpDown1.Value - numericUpDown2.Value);
			int siharai;
			if (numericUpDown2.Value < 127) {
				siharai = (int)numericUpDown1.Value;
			}
			else
			{
				siharai = ogori + ogori / (listBox2.Items.Count - 1);
			}
			//記録
			StreamWriter writer = new StreamWriter(logfile, true, Encoding.GetEncoding("Shift-JIS"));
			writer.Write(	System.DateTime.Now+","					//日時
							+siharai.ToString()+","	//おごり総額
							+label4.Text+","						//負けたひと
							+listBox2.Items.Count				//参加人数
						);
			for (int i = 0; i < listBox2.Items.Count; i++) {
				//敗者以外の参加者
				if(label4.Text != listBox2.Items[i].ToString())
					writer.Write(	","+listBox2.Items[i].ToString());
			}
			writer.Write(","+textBox1.Text+"\r\n");
			writer.Close();

			//twitter post
			if (checkBox2.Checked)
			{
				for (int i = 0; i < 100; i++)
				{
					if (label4.Text == pn[i].name)
					{
						string c_key = "lSDQuB0S0AvP222L8hQYg";
						string c_secret = "F7eskorSjP3qtMNROCjEfFKsJMCF6sg6AbiLKdiWto";
						string Token = "101163185-VVzxRhmiQpm7MlEfg81cqLqUWlBuSVKBHbZk2PBy";
						string TokenSecret = "fEDWQQ6acb5j2NKSx3IV4urWrixacxjatexBsgE9fk";

						string mes = "(DJC)今回の負け:" + pn[i].nickname + ", おごり:" + ogori.ToString() + "円,　\nコメント：" + textBox1.Text;
						TwitterUtils tu = new TwitterUtils();
						try
						{
							tu.UpdateStatusOAuth(string.Format("{0:s}/{1:s}",mes, DateTime.Now.ToString("HH:mm")),
						c_key, c_secret, Token, TokenSecret);
						}
						catch
						{
							MessageBox.Show("twitter.comにアクセスできません");
						}
						
						


						/* 旧　（ベーシック認証）
						const string EXP = "http://twitter.com/statuses/update.xml";
						const string user = "zakilab";
						const string pass = "kuraoka";
						string mes = "(DJC)今回の負け:" + pn[i].nickname + ", おごり:"+ogori.ToString()+"円,　\nコメント："+textBox1.Text;
						try
						{
							string result = PostData(EXP, user, pass, mes);//
						}
						catch {
							MessageBox.Show("twitter.comにアクセスできません");
						}
						*/

						break;
					}
				}
				
				
			}


			this.Dispose();
			
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Load_members();
		}

		private void listBox2_MouseClick(object sender, MouseEventArgs e)
		{
			//メンバーを右クリックしたとき
			if (e.Button == MouseButtons.Right) { 
				
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(listBox2.Items[listBox2.SelectedIndex]);
			listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("calc");
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			label14.Text = (numericUpDown1.Value - numericUpDown2.Value).ToString();
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			label14.Text = (numericUpDown1.Value - numericUpDown2.Value).ToString();
		}

		private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
		{
			label14.Text = (numericUpDown1.Value - numericUpDown2.Value).ToString();
			if (e.KeyCode == Keys.Enter) {
				numericUpDown2.Select();
			}
		}

		private void numericUpDown2_KeyUp(object sender, KeyEventArgs e)
		{
			label14.Text = (numericUpDown1.Value - numericUpDown2.Value).ToString();
			if (e.KeyCode == Keys.Enter)
			{
				button1.Select();
			}
		}

		private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
		{
			numericUpDown1.Text = string.Empty;
		}


		private void numericUpDown2_Enter(object sender, EventArgs e)
		{
			numericUpDown2.Text = string.Empty;
		}

		private void numericUpDown1_Enter(object sender, EventArgs e)
		{
			numericUpDown1.Text = string.Empty;
		}

		private void numericUpDown1_Leave(object sender, EventArgs e)
		{
			numericUpDown1.Text = numericUpDown1.Value.ToString();
		}

		private void numericUpDown2_Leave(object sender, EventArgs e)
		{
			numericUpDown2.Text = numericUpDown2.Value.ToString();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(listBox1.SelectedItem.ToString());
			
			try {
				string path = "img\\" + listBox1.SelectedItem.ToString() + ".jpg";
				pictureBox1.Image = Image.FromFile(path);
			}
			catch(Exception e3){
				pictureBox1.Image = Image.FromFile("img\\no_image.jpg");
			}
		}

		


			

		
	}
}
