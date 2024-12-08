using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
	internal class Urun
	{

		public string Ad;
		public double Fiyat;

		public void BilgiYazdir()
		{
			Console.WriteLine($"Ürün: {Ad}, Fiyat: {Fiyat} TL");
		}

	}
}
