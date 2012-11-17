using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ADJC
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		/// 

		[STAThread]
		static void Main()
		{
			//二重起動をチェックする
			if (System.Diagnostics.Process.GetProcessesByName(
				System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
			{
				//すでに起動していると判断して終了
				MessageBox.Show("すでに起動しています。実行ファイル名を変更してください。");
				return;
			}


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
