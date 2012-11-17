namespace ADJC
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button2 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.button4 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.設定ファイルのフォルダを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.更新履歴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.表の再読み込みToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.前回の結果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登録ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dJを登録するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label15 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(768, 625);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 58);
			this.button2.TabIndex = 2;
			this.button2.Text = "登録フォーム(F6)";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 39);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(877, 580);
			this.tabControl1.TabIndex = 3;
			this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(869, 554);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "ジャンケン表";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(863, 548);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridView1_SortCompare);
			this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label21);
			this.tabPage2.Controls.Add(this.label20);
			this.tabPage2.Controls.Add(this.label18);
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.numericUpDown1);
			this.tabPage2.Controls.Add(this.checkBox1);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Controls.Add(this.listBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(869, 554);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "もうけグラフ";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(204, 414);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(41, 12);
			this.label21.TabIndex = 15;
			this.label21.Text = "label21";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(144, 469);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(35, 12);
			this.label20.TabIndex = 14;
			this.label20.Text = "参加：";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(406, 444);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(35, 12);
			this.label18.TabIndex = 13;
			this.label18.Text = "備考：";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(277, 444);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(35, 12);
			this.label17.TabIndex = 12;
			this.label17.Text = "支払：";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(144, 444);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(35, 12);
			this.label16.TabIndex = 11;
			this.label16.Text = "敗者：";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(144, 412);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(54, 19);
			this.numericUpDown1.TabIndex = 10;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(6, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(94, 16);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "全グラフを表示";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Location = new System.Drawing.Point(10, 465);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(130, 76);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "連勝";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.ForeColor = System.Drawing.Color.Red;
			this.label19.Location = new System.Drawing.Point(26, 48);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 12);
			this.label19.TabIndex = 4;
			this.label19.Text = "label19";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(67, 36);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(41, 12);
			this.label14.TabIndex = 3;
			this.label14.Text = "label14";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(67, 15);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(41, 12);
			this.label13.TabIndex = 2;
			this.label13.Text = "label13";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(26, 36);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 12);
			this.label12.TabIndex = 1;
			this.label12.Text = "現在：";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(26, 15);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 12);
			this.label11.TabIndex = 0;
			this.label11.Text = "最多：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.ForeColor = System.Drawing.Color.Coral;
			this.label5.Location = new System.Drawing.Point(711, 393);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 12);
			this.label5.TabIndex = 6;
			this.label5.Text = "label5";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(10, 370);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(126, 89);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "儲け";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(67, 67);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 12);
			this.label10.TabIndex = 5;
			this.label10.Text = "label10";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(67, 43);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 12);
			this.label9.TabIndex = 4;
			this.label9.Text = "label9";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(67, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 12);
			this.label8.TabIndex = 3;
			this.label8.Text = "label8";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(14, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 12);
			this.label7.TabIndex = 2;
			this.label7.Text = "最小値：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 12);
			this.label6.TabIndex = 1;
			this.label6.Text = "最大値：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "現在値：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(152, 393);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(152, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(146, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(602, 400);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.Black;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(6, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(130, 328);
			this.listBox1.TabIndex = 0;
			this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dataGridView2);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(869, 554);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "相性表";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 21;
			this.dataGridView2.Size = new System.Drawing.Size(863, 548);
			this.dataGridView2.TabIndex = 0;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(669, 625);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(93, 58);
			this.button4.TabIndex = 6;
			this.button4.Text = "前回の結果(F4)";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.登録ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(901, 26);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ファイルToolStripMenuItem
			// 
			this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ファイルのフォルダを開くToolStripMenuItem,
            this.更新履歴ToolStripMenuItem});
			this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
			this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
			this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
			// 
			// 設定ファイルのフォルダを開くToolStripMenuItem
			// 
			this.設定ファイルのフォルダを開くToolStripMenuItem.Name = "設定ファイルのフォルダを開くToolStripMenuItem";
			this.設定ファイルのフォルダを開くToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.設定ファイルのフォルダを開くToolStripMenuItem.Text = "設定ファイルのフォルダを開く";
			this.設定ファイルのフォルダを開くToolStripMenuItem.Click += new System.EventHandler(this.設定ファイルのフォルダを開くToolStripMenuItem_Click);
			// 
			// 更新履歴ToolStripMenuItem
			// 
			this.更新履歴ToolStripMenuItem.Name = "更新履歴ToolStripMenuItem";
			this.更新履歴ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.更新履歴ToolStripMenuItem.Text = "更新履歴";
			this.更新履歴ToolStripMenuItem.Click += new System.EventHandler(this.更新履歴ToolStripMenuItem_Click);
			// 
			// 表示VToolStripMenuItem
			// 
			this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.表の再読み込みToolStripMenuItem,
            this.前回の結果ToolStripMenuItem});
			this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
			this.表示VToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.表示VToolStripMenuItem.Text = "表示(&V)";
			// 
			// 表の再読み込みToolStripMenuItem
			// 
			this.表の再読み込みToolStripMenuItem.Name = "表の再読み込みToolStripMenuItem";
			this.表の再読み込みToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.表の再読み込みToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.表の再読み込みToolStripMenuItem.Text = "表の再読み込み";
			this.表の再読み込みToolStripMenuItem.Click += new System.EventHandler(this.表の再読み込みToolStripMenuItem_Click);
			// 
			// 前回の結果ToolStripMenuItem
			// 
			this.前回の結果ToolStripMenuItem.Name = "前回の結果ToolStripMenuItem";
			this.前回の結果ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
			this.前回の結果ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.前回の結果ToolStripMenuItem.Text = "前回の結果";
			this.前回の結果ToolStripMenuItem.Click += new System.EventHandler(this.前回の結果ToolStripMenuItem_Click);
			// 
			// 登録ToolStripMenuItem
			// 
			this.登録ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dJを登録するToolStripMenuItem});
			this.登録ToolStripMenuItem.Name = "登録ToolStripMenuItem";
			this.登録ToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.登録ToolStripMenuItem.Text = "登録(&R)";
			// 
			// dJを登録するToolStripMenuItem
			// 
			this.dJを登録するToolStripMenuItem.Name = "dJを登録するToolStripMenuItem";
			this.dJを登録するToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.dJを登録するToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.dJを登録するToolStripMenuItem.Text = "DJを登録する";
			this.dJを登録するToolStripMenuItem.Click += new System.EventHandler(this.dJを登録するF5ToolStripMenuItem_Click);
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(21, 643);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(193, 12);
			this.label15.TabIndex = 11;
			this.label15.Text = "Presented by Yamazaki Kuraoka Lab.";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 625);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 12);
			this.label1.TabIndex = 10;
			this.label1.Text = "Advanced Dessert JANKEN Counter";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// checkBox2
			// 
			this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(1, 678);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(222, 16);
			this.checkBox2.TabIndex = 12;
			this.checkBox2.Text = "自動更新(通常はチェックしておいて下さい)";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(365, 630);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 53);
			this.button1.TabIndex = 13;
			this.button1.Text = "発声練習(仮)";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(901, 695);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "ADJC 1.6";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 設定ファイルのフォルダを開くToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 更新履歴ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 表の再読み込みToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 前回の結果ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登録ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dJを登録するToolStripMenuItem;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Button button1;
	}
}

