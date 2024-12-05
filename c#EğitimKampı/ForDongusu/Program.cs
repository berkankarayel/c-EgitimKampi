using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// 1 den başlayıp 5 e kadar sayıları ekrana yazdıran program 

			for (int i = 1; i <= 5; i++)
			{
				Console.WriteLine($"Sayı: {i}");
			}


			// 1. Örnek: Orta Seviye Uygulama 

			// Görev: 1 ile 100 arasındaki çift sayıların toplamını hesaplayıp ekrana yazdıran bir program yazın.

			int toplam = 0;

			for (int j = 1; j <= 100; j++)
			{
				if (j % 2 == 0)
				{
					toplam += j;
				}
				
			}
            Console.WriteLine(toplam);
			Console.ReadLine();


			// 2. Örnek: Zor Uygulama
			//Görev: Kullanıcıdan bir sayı alın ve bu sayının asal olup olmadığını kontrol eden bir program yazın.

			Console.WriteLine("Bir sayı girin:");
			int sayi = Convert.ToInt32(Console.ReadLine());
			bool asal = true;

			if (sayi <= 1)
			{
				asal = false; // 1 ve daha küçük sayılar asal değildir.
			}
			else
			{
				for (int i = 2; i < sayi; i++)
				{
					if (sayi % i == 0)
					{
						asal = false;
						break; // Asal olmadığını bulduktan sonra döngüden çıkarız
					}
				}
			}

			if (asal)
			{
				Console.WriteLine($"{sayi} asaldır.");
			}
			else
			{
				Console.WriteLine($"{sayi} asal değildir.");
			}

			Console.ReadLine();


            //Zor Örnek: While Döngüsü ile Sayının Basamaklarını Ters Çevirme
            //Kullanıcıdan bir tam sayı alın ve bu sayının basamaklarını ters çevirip ekrana yazdıran bir program yazın. Negatif sayılar için işaret korunsun.

            Console.WriteLine("Bir tam sayı giriniz");
			int sayi_1 = Convert.ToInt32(Console.ReadLine());
			int orijinalSayi = sayi_1;

			int tersayi = 0;

			bool negatif = false;

			if(sayi_1 < 0)
			{
				negatif = true;
				sayi_1 =-sayi_1;
			}


			while (sayi_1 > 0)
			{
				int basamak = sayi_1 % 10;
				tersayi = (tersayi * 10) + basamak;
				sayi_1 /= 10;

			}

			if (negatif)
			{
				tersayi = -tersayi;
			}

            Console.WriteLine($"{orijinalSayi} sayısının tersi: {tersayi} ");
			Console.ReadLine();




		}
	}
}
