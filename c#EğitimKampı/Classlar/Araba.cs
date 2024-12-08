using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
	internal class Araba
	{

		public string Marka;  // Alan
		public string Model;  // Alan
		public int Yil;       // Alan

		// Metot
		public void BilgiYazdir()
		{
			Console.WriteLine($"Araba: {Marka} {Model}, Yıl: {Yil}");
		}

	}
}
