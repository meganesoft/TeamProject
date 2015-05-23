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

		public string ID_library {set;get;}

		Process p;
		ProcessStartInfo psInfo = new ProcessStartInfo();


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
			FilePass = filepass;

			
			string command = filepass;

			

			psInfo.FileName = command; // 実行するファイル
			psInfo.CreateNoWindow = true; // コンソール・ウィンドウを開かない
			psInfo.UseShellExecute = false; // シェル機能を使用しない

			psInfo.RedirectStandardOutput = true; // 標準出力をリダイレクト

			this.p = Process.Start(psInfo); // アプリの実行開始
			
			
				
			
		}

		public async Task<string> Reading_Id()
		{
			string Plane_ID = await Task.FromResult<string>(p.StandardOutput.ToString());

			this.ID_library = Plane_ID;
			return this.ID_library;
		}

		void Reading_ID()
		{
			
		}

		
		

	}
}
