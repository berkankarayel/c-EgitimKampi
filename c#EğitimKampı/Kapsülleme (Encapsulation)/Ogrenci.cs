using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme__Encapsulation_
{
	internal class Ogrenci
	{

		private string isim; // dışarıdan erişilemez. 

		// Geter ve setter metotoları 

		public string GetIsim()
		{
			return isim;
		}

		public void SetIsim(string yeniIsim)
		{
			if (!string.IsNullOrEmpty(yeniIsim)) // Boş değilse
			{
				isim = yeniIsim;
			}
			else
			{
				Console.WriteLine("İsim boş bırakılamaz!");
			}
		}

		public string Isim1 { get; set; } // Otomatik özellik
		public int Yas1 { get; set; }


	}
}
