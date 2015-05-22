using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace TeamProject.Models
{
	class IDRead
	{
		/*public IDRead(string filepass)
		{		
			this.FilePass = filepass;
		}*/

		private string FilePass;

		private int ID;

		Process p;

		public int get_ID()
		{
			return ID;
		}

		/*public void Get_Text()
		{
			string[] lines = File.ReadAllLines(FilePass);

			this.PriceText =
				from line in lines
				let x = line.Split(',')
				select x[0];

			this.IdText =
				from line in lines
				let x = line.Split(',')
				select x[1];

		}*/

		public IDRead(string filepass)
		{
			string command = filepass;

			ProcessStartInfo psInfo = new ProcessStartInfo();

			psInfo.FileName = command; // 実行するファイル
			psInfo.CreateNoWindow = true; // コンソール・ウィンドウを開かない
			psInfo.UseShellExecute = false; // シェル機能を使用しない

			psInfo.RedirectStandardOutput = true; // 標準出力をリダイレクト

			this.p = Process.Start(psInfo); // アプリの実行開始
			string output = p.StandardOutput.ReadToEnd();	// 標準出力の読み取り

			this.ID = int.Parse(output);
			Console.WriteLine(ID);	
			
		}

		public async void Reading_Id()
		{
			this.ID = int.Parse(p.StandardOutput);
		}

		

	}
}
