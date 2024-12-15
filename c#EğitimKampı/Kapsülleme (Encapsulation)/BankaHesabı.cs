using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme__Encapsulation_
{
	internal class BankaHesabı
	{

		private double bakiye;

        public BankaHesabı(double baslangıcBakiyesi)
        {
            bakiye = baslangıcBakiyesi;            
        }

		public void ParaYatir(double miktar)
		{
			if (miktar > 0)
			{
				bakiye += miktar;
				Console.WriteLine($"{miktar} TL hesaba yatırıldı.");
			}
			else
			{
				Console.WriteLine("Yatırılacak miktar pozitif olmalıdır!");
			}
		}

		public void ParaCek(double miktar)
		{
			if (miktar > 0 && miktar <= bakiye)
			{
				bakiye -= miktar;
				Console.WriteLine($"{miktar} TL hesaptan çekildi.");
			}
			else
			{
				Console.WriteLine("Yetersiz bakiye veya geçersiz miktar!");
			}
		}

		public void BakiyeGoster()
		{
			Console.WriteLine($"Hesaptaki bakiye: {bakiye} TL");
		}

	}
}
