﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Windows;
using TeamProject.ViewModels;

namespace TeamProject.Models
{
	class IDRead
	{
		private string Plane_ID="";
		private string FilePass;
		private string db_file = @"C:\Users\Meganesoft\Documents\Visual Studio 2015\Projects\TeamProject\TeamProject\Resource\ictags_meteo.db";
		public string ID_library {set;get;}
		private int denomination_library {set;get;}

		Process p;
		ProcessStartInfo psInfo = new ProcessStartInfo();
		Dictionary<string,int> DB_Dictionary = new Dictionary<string,int>();
	

		public IDRead(string filepass)
		{
			FilePass = filepass;
		
			string command = filepass;

			psInfo.FileName = command; // 実行するファイル
			psInfo.CreateNoWindow = true; // コンソール・ウィンドウを開かない
			psInfo.UseShellExecute = false; // シェル機能を使用しない

			psInfo.RedirectStandardOutput = true; // 標準出力をリダイレクト

			if((Process.GetCurrentProcess().ProcessName).Length > 1)
			{
				this.p = Process.Start(psInfo); // アプリの実行開始
			}
						
		}

		public async Task Reading_Id()
		{	
			if(p.HasExited)
			{
				this.p = Process.Start(psInfo);
			}
			Plane_ID = await Task.FromResult<string>(p.StandardOutput.ReadLine().ToString());
			p.WaitForExit();
			Plane_ID = Plane_ID.TrimEnd();
			Call_DataBase();
		}

		//SQLをつかってデータベースからIDタグのIDを読みだしてる
		public void Call_DataBase()
		{
			//Data Source=でデータベースファイルを指定
			using (var conn = new SQLiteConnection("Data Source=" + db_file))
			{
				conn.Open();
				using (SQLiteCommand command = conn.CreateCommand())
				{
					//SQLコマンドの設定
					command.CommandText = "SELECT denomination FROM ictagtbl WHERE id='"+Plane_ID+"'";
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while(reader.Read())
						{
							//denominationキーを読みだし、denomination_librarypropetyに格納
							int denomination = Convert.ToInt32(reader["denomination"].ToString());
							denomination_library = denomination;							
						}			
					}
				}
				conn.Close();									
			}		
		}

		public string get_denomination()
		{
			return denomination_library.ToString();
		}
	}
}
