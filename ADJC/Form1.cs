/* todo
・
・最大支払い（おごり）金額
・参加率
・グラフにグリッド
・シミュレーション？
・
・メンバーファイルに読み方を追加
*/

/* readme
・menber.txtに無い名前がlog.txtにあるとまずい。
・xpと7で微妙に動作が違う：picturebox上でマウスホイール下後の、描写の更新
・
*/






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
	public partial class Form1 : Form
	{

		const string memberfile = "member.txt";
		const string logfile = "log.txt";
		const string moukefile = "mouke.txt";
		int total_jdc=0;	//ログファイルの行数
		int y_abs_g;
		int dj_number = 1;//グラフで注目するDJの開催番号
		int pindex = 0; //強調表示させる人のID
		bool isMouseDown = false;

		public static string z_line="";

		struct Log { 
			public string time,haisya,biko;
			public int yen,sanka;
			public string[] syosya;
			
		}

		Log[] log=new Log[1000];
	

		struct Person {
			public string name;
			public int id,sanka, make,rensho,rs_max;//rs_maxは過去の最大連勝
			public double tuyosa,ogori;
			public float mouke, mk_max, mk_min;	//tuyosa:ジャンケン力
		}

		Person[] p;

		float[,] tjm;	//対人もうけ　右上がもうけ
					//tjm[i,j]（右上）は列iの行jからのもうけ
		ToolTip toolTip1 = new ToolTip();

		public Form1()
		{
			InitializeComponent();
			//表について
			init_grid();
			load_member();
			load_log();

			//グラフについて
			listBox1.SelectedIndex = 0;
			draw_graph(pindex);

			
			//ホイール
			// 予め、コントロールにフォーカスを当ててやる必要があるので注意。
			//this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
			// マウスのホイールを検出するイベントハンドラーを追加する。
			// MouseWheelイベントは、VS.NETのデザイナのイベント一覧に出てこないので、
			// 下記のように手動で追加する必要があります。
			this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseWheel);

			//this.ResumeLayout(false);


			

		}
		//表の初期化関数
		private void init_grid()
		{
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnCount = 7;
			dataGridView1.RowCount = 100;

			dataGridView1.Columns[0].Name = "名前";
			dataGridView1.Columns[1].Name = "参加数[回]";
			dataGridView1.Columns[2].Name = "敗北数[回]";
			dataGridView1.Columns[3].Name = "ジャンケン力[-]";
			dataGridView1.Columns[4].Name = "おごり総額[円]";
			dataGridView1.Columns[5].Name = "もうけ総額[円]";
			dataGridView1.Columns[6].Name = "勝率[%]";

			dataGridView1.Columns[2].ToolTipText = "おごった回数です";
			dataGridView1.Columns[3].ToolTipText = "参加したすべてのデザートジャンケンがタイマンであったら、何回勝ち越しているかを表します。";
			dataGridView1.Columns[4].ToolTipText = "みんなの為に支払った合計金額です。";
			dataGridView1.Columns[5].ToolTipText = "自分で買うより、いくら得したかです。";
			dataGridView1.Columns[6].ToolTipText = "(勝利回数/参加回数)×100[%]";


			//dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			//右寄せ
			dataGridView1.DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleRight;
			dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//行ヘッダーの幅調整
			dataGridView1.RowHeadersWidth = 50;
			//行ヘッダーに番号をつける
			for (int i = 0; i < dataGridView1.RowCount; i++)
			{
				dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
			}
			
			//
			//
			//対人表について
			dataGridView2.AutoGenerateColumns = false;
			dataGridView2.ColumnCount = 20;
			dataGridView2.RowCount = 20;

			//右寄せ
			dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			//dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			//行ヘッダーの幅調整
			dataGridView2.RowHeadersWidth = 110;
			
		}

		//メンバー読み込み関数
		private void load_member()
		{
			if (!File.Exists(memberfile)) {
				MessageBox.Show("メンバーファイルがありません。");
				MessageBox.Show("member.txtというファイルを作成し、一行ごとに名前を入力してください。");
				this.Dispose();
			}

			listBox1.Items.Clear();

			StreamReader reader = new StreamReader(memberfile, Encoding.GetEncoding("Shift_JIS"));

			string line;
			int i;
			
			for (i = 0; (line = reader.ReadLine()) != null; i++)
			{
				if (line == "")
				{
					i--;
				}
				else
				{
					line = line.Split(',')[0];
					dataGridView1.Rows[i].Cells[0].Value = line;
					listBox1.Items.Add(line);
				}
			}

			
			reader.Close();
			dataGridView1.RowCount = i;

			dataGridView2.RowCount = i;
			dataGridView2.ColumnCount = i;

			p = new Person[i];
			tjm = new float[i,i];
			
			for (int j = 0; j < i; j++) {
				p[j].id = j;
				p[j].name = dataGridView1[0,j].Value.ToString();
			}
			
		}

		//ログ読み込み関数　同時に　グラフ用のもうけファイルを作る
		private void load_log() {
			if (!File.Exists(logfile))
			{
				//MessageBox.Show("ログファイルがありません");
				button4.Enabled = false;
				return;
			}

			StreamReader reader = new StreamReader(logfile, Encoding.GetEncoding("Shift_JIS"));
			StreamWriter writer = new StreamWriter(moukefile,false,Encoding.GetEncoding("Shift_JIS"));

			
			string line;

			string[] cell;
			int i;
			for (i = 0; true; i++)
			{
				
				line = reader.ReadLine();
				if (line == null) {
					break;
				}
				if(line ==""){
					MessageBox.Show("log.txtが不正です。末尾1行だけ空白にして下さい");
					this.Close();
				}
				
				cell = line.Split(',');	//0日時、1金額、2敗者、3参加人数ｎ、4参加者１、...、参加者ｎ-1
				if (cell.Length != int.Parse(cell[3])+4) {
					MessageBox.Show("log.txtが不正です。改行し忘れ？");
					this.Close();
				}

				//log 構造体に代入
				log[i].time = cell[0];
				log[i].yen = int.Parse(cell[1]);
				log[i].haisya = cell[2];
				log[i].sanka = int.Parse(cell[3]);

				log[i].syosya = new string[log[i].sanka-1];
				for (int j = 0; j < log[i].sanka - 1; j++)
				{
						log[i].syosya[j] = cell[4 + j];
				}
				log[i].biko = cell[cell.Length-1];

				



					//敗者について
					p[get_id(cell[2])].make += 1;
				p[get_id(cell[2])].sanka += 1;
				p[get_id(cell[2])].ogori += int.Parse(cell[1]) - int.Parse(cell[1]) / int.Parse(cell[3]);
				p[get_id(cell[2])].tuyosa -= 2*(1-1.0/int.Parse(cell[3]));
				p[get_id(cell[2])].mouke -= int.Parse(cell[1]) - int.Parse(cell[1]) / int.Parse(cell[3]);
				if (p[get_id(cell[2])].mouke < p[get_id(cell[2])].mk_min) { 
					p[get_id(cell[2])].mk_min=p[get_id(cell[2])].mouke;
				}
				if (p[get_id(cell[2])].rensho > p[get_id(cell[2])].rs_max) {
					p[get_id(cell[2])].rs_max = p[get_id(cell[2])].rensho;
				}
				p[get_id(cell[2])].rensho = 0;

				//勝者について
				for (int j = 4; j < cell.Length-1; j++) {
					p[get_id(cell[j])].sanka += 1;
					p[get_id(cell[j])].mouke += int.Parse(cell[1]) / int.Parse(cell[3]);
					p[get_id(cell[j])].tuyosa += 2*(1.0 / int.Parse(cell[3]));
					if (p[get_id(cell[j])].mouke > p[get_id(cell[j])].mk_max)
					{
						p[get_id(cell[j])].mk_max = p[get_id(cell[j])].mouke;
					}
					p[get_id(cell[j])].rensho += 1;

					

					//相性表の処理
					tjm[get_id(cell[2]),get_id(cell[j])] += int.Parse(cell[1]) / int.Parse(cell[3]);
					tjm[get_id(cell[j]),get_id(cell[2])] -= int.Parse(cell[1]) / int.Parse(cell[3]);

				}

				//ファイルに書き込み
				writer.Write(p[0].mouke);
				for (int k = 1; k < p.Length; k++) {
					writer.Write(","+p[k].mouke);
				}
				writer.Write("\r\n");

				z_line = line;

				
				
			}
			
			
			

			total_jdc=i;
			numericUpDown1.Maximum = total_jdc;
			//表に反映


			for (i = 0; i < p.Length; i++ ) {
				dataGridView1[1, i].Value = p[i].sanka;
				dataGridView1[2, i].Value = p[i].make;
				dataGridView1[3, i].Value = String.Format("{0:f2}",p[i].tuyosa);
				dataGridView1[4, i].Value = String.Format("{0:f0}",p[i].ogori);
				dataGridView1[5, i].Value = String.Format("{0:f0}",p[i].mouke);
				if(p[i].sanka != 0)
					dataGridView1[6, i].Value = String.Format("{0:f1}",100.0*(p[i].sanka-p[i].make)/p[i].sanka);
			}

			//対人表
			for (int j = 0; j < p.Length; j++) {
				for (int k = 0; k < p.Length; k++) {
					if (j != k)
					{
						dataGridView2[j, k].Value = string.Format("{0:f0}", tjm[j, k]);
						
						//対人表(相性表)ツールチップ
						dataGridView2[j, k].ToolTipText = p[k].name + " の " + p[j].name + " からのもうけ：" + dataGridView2[j, k].Value.ToString();
					}
					else
					{
						dataGridView2[j, k].Value = "/";
					}

				}
				dataGridView2.Columns[j].HeaderCell.Value =
					dataGridView2.Rows[j].HeaderCell.Value =
					dataGridView1[0, j].Value;
			}





			if (total_jdc > 0)
			{
				button4.Enabled = true;
			}

			reader.Close();
			writer.Close();
		}

		//personの名前のidを返す関数
		int get_id(string n) {
			for (int i = 0; i < p.Length; i++) {
				if (n == p[i].name) return p[i].id;
			}

			MessageBox.Show("menber.txtに無い名前がlog.txtにある…。");
			this.Dispose();
			return -1;
		}

		//グラフ描写関数
		private void draw_graph(int id) {
			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Graphics g = Graphics.FromImage(pictureBox1.Image);

			Pen pen = new Pen(Color.White);
			Pen pen2 = new Pen(Color.White,2);
			SolidBrush brush = new SolidBrush(Color.Black);
			g.FillRectangle(brush,0,0,pictureBox1.Width,pictureBox1.Height);//黒く塗りつぶす
			//g.DrawLine(pen, 10,20,100,200);
			g.DrawLine(pen, dj_number * pictureBox1.Width / total_jdc, 0, dj_number * pictureBox1.Width / total_jdc, pictureBox1.Height);
			if (!File.Exists(moukefile))
			{
				//MessageBox.Show("もうけファイルがありません");
				return;
			}
			if (total_jdc == 0) return;

			StreamReader reader = new StreamReader(moukefile, Encoding.GetEncoding("Shift_JIS"));
			string line;
			string[] mouke=new string[p.Length];
			int[] mk = new int[p.Length];
			int[] mk2 = new int[p.Length];

			float dx = (float)(1.0*pictureBox1.Width/total_jdc);	//直線のｘ幅
			int y_abs = -10000;
			int y_max = -10000;						//ｙの最大値
			int y_min =  10000;

			for (int i = 0; (line = reader.ReadLine()) != null; i++)
			{
				mouke = line.Split(',');
				for (int j = 0; j < mouke.Length; j++)
				{
					mk[j] = int.Parse(mouke[j]);
					if (Math.Abs( mk[j]) > y_abs) y_abs = Math.Abs(mk[j]);
					if (mk[j] > y_max) y_max = mk[j];
					if (mk[j] < y_min) y_min = mk[j];
				}
			}
			reader.Close();

			reader = new StreamReader(moukefile, Encoding.GetEncoding("Shift_JIS"));
			for(int i = 0; (line = reader.ReadLine()) != null; i++)
			{
				mouke = line.Split(',');
				int[] RGB=new int[3];


				//選択されてない人
				for (int k = 0; k < p.Length; k++)
				{
					RGB = getRGB(k,p.Length);
					pen.Color = Color.FromArgb(0xFF, RGB[0], RGB[1], RGB[2]);//
					mk[k] = int.Parse(mouke[k]);
					if (checkBox1.Checked) g.DrawLine(pen, dx * i, 200 - mk2[k] * 180 / y_abs, dx * (i + 1), 200 - mk[k] * 180 / y_abs);
					else g.DrawLine(pen, dx * i, 200, dx * (i + 1), 200);

					
					
				}
				

				//選択されたidの人について
				//if (mk2[id] <= mk[id])pen.Color = Color.White;//勝ち
				//else if (mk2[id] == mk[id])pen.Color = Color.Green;//休み
				//else pen.Color = Color.White;//負け
		
				g.DrawLine(pen2, dx * i, 200 - mk2[id] * 180 / y_abs, dx * (i + 1), 200 - mk[id] * 180 / y_abs);

				y_abs_g = y_abs;

				mk.CopyTo(mk2, 0);
			}

			


			label2.Text = "max : " + y_max.ToString();
			label3.Text = "min : " + y_min.ToString();
			label5.Text = total_jdc.ToString() + "回";

			label8.Text = p[id].mouke.ToString();
			label9.Text = p[id].mk_max.ToString();
			label10.Text = p[id].mk_min.ToString();

			label13.Text = p[id].rs_max.ToString();
			label14.Text = p[id].rensho.ToString();

			//連勝記録更新中の時
			if (p[id].rs_max < p[id].rensho)
			{
				label19.Text = "記録更新中!";
				label13.Text = label14.Text;
			}
			else 
			{
				label19.Text = "";
			}

			reader.Close();

			//注目するdj開催番号について
			label16.Text = "敗者："+log[dj_number-1].haisya;
			label17.Text = "支払：\\" + log[dj_number - 1].yen;
			label18.Text = "備考：" + log[dj_number - 1].biko;
			string s = "参加：";
			for (int k = 0; k < log[dj_number - 1].sanka - 1; k++) {
				s += log[dj_number - 1].syosya[k]+",  ";
				if (k == 7 || k == 14) s += "\n";
			}
			label20.Text = s;
			label21.Text = log[dj_number - 1].time;
		}
		
		//色分けのRGBを返す関数
		private int[] getRGB(int i, int max) {
			int R,G,B;
			

			if (i < max / 4.0)
			{
				R = 0xFF;
				G = 0xFF * 4 * i / max;
				B = 0;
			}
			else if (i < max / 2.0)
			{
				R = 0xFF - 0xFF * 4 * (i - max / 4) / max;
				G = 0xFF;
				B = 0;
			}
			else if (i < max * 3.0 / 4.0)
			{
				R = 0;
				G = 0xFF;
				B = 0xFF * 4 * (i - max / 2) / max;
			}
			else
			{
				R = 0;
				G = 0xFF - 0xFF * 4 * (i - max * 3 / 4) / max;
				B = 0xFF;
			}
			if (R < 0) R = 0; if (R > 255) R = 255;
			if (G < 0) G = 0; if (G > 255) G = 255;
			if (B < 0) B = 0; if (B > 255) B = 255;

			int[] rgb={R,G,B};

			return rgb;

		}


		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Form2 form2 = new Form2();
			form2.ShowDialog();
			timer1.Enabled = true;

			load_member();
			load_log();

			//グラフについて
			draw_graph(pindex);
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("ファイルを編集したら、プログラムを再起動して下さい。");
			System.Diagnostics.Process.Start(Application.StartupPath);
		}

		//更新
		private void button3_Click(object sender, EventArgs e)
		{
			total_jdc = 0;
			load_member();
			load_log();

			//グラフについて
			draw_graph(pindex);
		}

		private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//行ヘッダーに番号をつける
			for (int i = 0; i < dataGridView1.RowCount; i++)
			{
				dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			pindex = listBox1.SelectedIndex;
			draw_graph(pindex);
		}

		//ソートの仕方を指定
		private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			try
			{
				if (e.Column.Index != 0)
				{
					if ((double.Parse(e.CellValue1.ToString())) > (double.Parse(e.CellValue2.ToString())))
					{
						e.SortResult = 1;
					}
					else if ((double.Parse(e.CellValue1.ToString())) == (double.Parse(e.CellValue2.ToString())))
					{
						e.SortResult = 0;
					}
					else
					{
						e.SortResult = -1;
					}

					e.Handled = true;
				}
			}catch(Exception e2){
			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Form3 form3 = new Form3();
			form3.form1 = this;
			form3.ShowDialog();
			timer1.Enabled = true;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			draw_graph(listBox1.SelectedIndex);
		}


		private void Form1_MouseEnter(object sender, System.EventArgs e)
		{
			// 今回は必要ないが、パネルやパネル内のコントロールでマウスの
			// ホイールを検出するには、予め、そのコントロールにフォーカスを
			// 当ててやる必要がある。
			// これを忘れるとイベントが起こらないので注意。
			// この事について触れているサンプルが少なく、私もはまった。
			//this.Focus();
		}

		private void Form1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  // Delta はホイールが1回カチッっとなると、+120/-120という値になる。
		  // よって、120で割ってあげれば解りやすい値になる。
			//this.label1.Text = "ホイール検出： " + (e.Delta / 120);

			if (0 <= (listBox1.SelectedIndex - e.Delta / 120) && (listBox1.SelectedIndex - e.Delta / 120)<listBox1.Items.Count)
			{ 
				listBox1.SelectedIndex += -e.Delta / 120;
			}
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//listbox1をオーナードローモードに
			listBox1.DrawMode = DrawMode.OwnerDrawFixed;

			

		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			//toolTip1.SetToolTip(pictureBox1 ,("第"+e.X*total_jdc/pictureBox1.Width).ToString()+"回：約"+((200-e.Y)*y_abs_g/180).ToString()+"円");
			
		}

		private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
			//オーナードロー
			//背景を描画する
			//項目が選択されている時は強調表示される
			e.DrawBackground();

			int[] RGB = new int[3];

			//ListBoxが空のときにListBoxが選択されるとe.Indexが-1になる
			if (e.Index > -1)
			{
				//文字を描画する色の選択
				Brush b = null;
				if ((e.State & DrawItemState.Selected) != DrawItemState.Selected)
				{
					//選択されていない時
					RGB = getRGB(e.Index,p.Length);
					b = new SolidBrush(Color.FromArgb(RGB[0],RGB[1],RGB[2]));
				}
				else
				{
					//選択されている時はそのままの前景色を使う
					b = new SolidBrush(e.ForeColor);
				}
				//描画する文字列の取得
				string txt = ((ListBox)sender).Items[e.Index].ToString();
				//文字列の描画
				e.Graphics.DrawString(txt, e.Font, b, e.Bounds);
				//後始末
				b.Dispose();
			}

			//フォーカスを示す四角形を描画
			e.DrawFocusRectangle();

		}

		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			this.Focus();
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Form4 form4 = new Form4();
			form4.ShowDialog();
			timer1.Enabled = true;
		}

		private void 設定ファイルのフォルダを開くToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("ファイルを編集したら、プログラムを再起動して下さい。");
			System.Diagnostics.Process.Start(Application.StartupPath);
		}

		private void 更新履歴ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Form4 form4 = new Form4();
			form4.ShowDialog();
			timer1.Enabled = true;
		}

		private void 表の再読み込みToolStripMenuItem_Click(object sender, EventArgs e)
		{
			total_jdc = 0;
			load_member();
			load_log();

			//グラフについて
			draw_graph(pindex);
		}

		private void 前回の結果ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Form3 form3 = new Form3();
			form3.form1 = this;
			form3.ShowDialog();
			timer1.Enabled = true;
		}

		private void dJを登録するF5ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Form2 form2 = new Form2();
			form2.ShowDialog();
			timer1.Enabled = true;

			load_member();
			load_log();

			//グラフについて
			draw_graph(pindex);
		}


		//更新チェック
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (File.Exists("next_version//ADJC.exe")
				&& File.Exists("auto_updater.exe")
				&& checkBox2.Checked)
			{
				timer1.Enabled = false;
				//MessageBox.Show("新しいバージョンがあります");
				System.Diagnostics.Process.Start("auto_updater.exe");
				Application.Exit();
			}
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			
			dj_number = e.X * total_jdc / pictureBox1.Width+1;
			
			//draw_graph(dj_number2pindex(dj_number));
			numericUpDown1.Value = dj_number;
			isMouseDown = true;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			dj_numberCanged();
		}
		public void dj_numberCanged() {
			dj_number = (int)numericUpDown1.Value;
			//draw_graph(dj_number2pindex(dj_number));
			listBox1.SelectedIndex = dj_number2pindex(dj_number);
			draw_graph(pindex);
		}

		public int dj_number2pindex(int djn) {
			string name = log[dj_number - 1].haisya;
			for (int i = 0; i < listBox1.Items.Count; i++) { 
				if(name==listBox1.Items[i].ToString()){
					return i;
				}
				
			}
			
			return -1;
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			isMouseDown = false;
		}

		private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
		{
			if(isMouseDown){
				if (1 < e.X && e.X < pictureBox1.Width)
				{
					dj_number = e.X * total_jdc / pictureBox1.Width + 1;
					numericUpDown1.Value = dj_number;
				}else if(e.X >= pictureBox1.Width){
					dj_number = total_jdc;
					dj_numberCanged();
				}else if(e.X <= 1){
					dj_number = 1;
					dj_numberCanged();
				}
			}
		}

		

		private void tabControl1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right)
			{
				if (numericUpDown1.Value < numericUpDown1.Maximum)
				{
					numericUpDown1.Value++;
					e.Handled = true;
				}
				else
				{
					dj_numberCanged();
					e.Handled = true;
				}
			}
			else if (e.KeyCode == Keys.Left)
			{
				if (numericUpDown1.Value > numericUpDown1.Minimum)
				{
					numericUpDown1.Value--;
					e.Handled = true;
				}
				else {
					dj_numberCanged();
					e.Handled = true;
				}
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Form5 form5 = new Form5();
			form5.ShowDialog();
			timer1.Enabled = true;
		}


		

		

		

		

		
		
	}
}
