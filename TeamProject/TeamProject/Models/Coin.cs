using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TeamProject.Models
{
	class Coin
	{
		//貨幣の金額(コンストラクタ)
		public Coin(int x)
		{
		}


		private int Coin_Orijinal;
		private string Coin_Version;
	
		//ゲーム内で処理する貨幣の金額
		private int Coin_Price;
	
		//貨幣の描画
		//描画する位置などのコードは未実装
		/*public void Coin_Draw()
		{
			//描画先となるImageオブジェクトを作成する
			Bitmap canvas = new Bitmap(PictureBox1.Width,PictureBox1.Height);
			//ImageオブジェクトのGraphicsオブジェクトを作成する
			Graphics g = Graphics.FromImage(canvas);
			//Penオブジェクトの作成
			Pen p = new Pen(Coin_Version_Judge, 1);
			g.DrawRectangle(p, 10, 20, 100, 80);
		
			//リソースを解放する
			p.Dispose();
			g.Dispose();

			//PictureBox1に表示する
			PictureBox1.Image = canvas;
		}*/
	
		//貨幣の種類を判定して色の値を送る
		public string Coin_Version_Judge(int Coin_Price)
		{
			if (Coin_Price == 1) {return "Color.Silver";}
			if (Coin_Price == 5) {return "Color.Gold";}
			if (Coin_Price == 10) {return "Color.Brown";}
			if (Coin_Price == 50) {return "Color.Silver";}
			if (Coin_Price == 100) {return "Color.Silver";}
			if (Coin_Price == 500) {return "Color.LightGoldenrodYellow";}
			return "Color.Black";
		}
	
	
		//描画される貨幣の位置
		public void Coin_Draw_Position()
		{
		}
	}
}
