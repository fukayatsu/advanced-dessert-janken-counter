namespace ADJC
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "メンバー";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(12, 24);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 172);
			this.listBox1.TabIndex = 1;
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 12;
			this.listBox2.Location = new System.Drawing.Point(171, 24);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(120, 172);
			this.listBox2.TabIndex = 2;
			this.listBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseClick);
			this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(169, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 12);
			this.label2.TabIndex = 90;
			this.label2.Text = "今回の参加者：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(331, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "おごってくれた人";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(329, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 24);
			this.label4.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(402, 294);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 72);
			this.button1.TabIndex = 3;
			this.button1.Text = "登録する";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(338, 294);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(58, 72);
			this.button2.TabIndex = 7;
			this.button2.Text = "やり直す";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "※ダブルクリックで右へ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(142, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 12);
			this.label6.TabIndex = 9;
			this.label6.Text = "→";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(305, 57);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 12);
			this.label7.TabIndex = 10;
			this.label7.Text = "→";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(169, 199);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(124, 12);
			this.label16.TabIndex = 17;
			this.label16.Text = "※おごってくれた人を選択";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(246, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 12);
			this.label8.TabIndex = 18;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(195, 255);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(310, 19);
			this.textBox1.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(193, 240);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 12);
			this.label9.TabIndex = 20;
			this.label9.Text = "備考(コメント)";
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(138, 115);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(24, 23);
			this.button3.TabIndex = 21;
			this.button3.Text = "←";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(12, 358);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(93, 16);
			this.checkBox1.TabIndex = 22;
			this.checkBox1.Text = "音声読み上げ";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(12, 336);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(121, 16);
			this.checkBox2.TabIndex = 23;
			this.checkBox2.Text = "結果をtwitterにpost";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(210, 336);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(83, 30);
			this.button4.TabIndex = 24;
			this.button4.Text = "電卓を起動";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Location = new System.Drawing.Point(321, 102);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(177, 97);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "おごり額計算";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(108, 73);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(23, 12);
			this.label14.TabIndex = 6;
			this.label14.Text = "100";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(17, 73);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 12);
			this.label13.TabIndex = 5;
			this.label13.Text = "(純おごり額)";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(14, 61);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(149, 12);
			this.label12.TabIndex = 4;
			this.label12.Text = "------------------------";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericUpDown2.Location = new System.Drawing.Point(110, 39);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(51, 19);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
			this.numericUpDown2.Leave += new System.EventHandler(this.numericUpDown2_Leave);
			this.numericUpDown2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown2_KeyUp);
			this.numericUpDown2.Enter += new System.EventHandler(this.numericUpDown2_Enter);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(10, 41);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 12);
			this.label11.TabIndex = 2;
			this.label11.Text = "－(自分の分)";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericUpDown1.Location = new System.Drawing.Point(110, 17);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(51, 19);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown1_Leave);
			this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
			this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown1_Enter);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(10, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 12);
			this.label10.TabIndex = 0;
			this.label10.Text = "(支払い合計)";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(319, 202);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(94, 12);
			this.label15.TabIndex = 91;
			this.label15.Text = "※入力したらEnter";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Location = new System.Drawing.Point(14, 214);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.TabIndex = 92;
			this.pictureBox1.TabStop = false;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 378);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "DJCの結果を記録";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}