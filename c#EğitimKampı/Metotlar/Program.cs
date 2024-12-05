using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// Parametresiz ve Geriye Değer Döndürmeyen Metotlar

			//Geriye Değer Döndürmeyen:  void anahtar kelimesi ile tanımlanır.

			//Parametresiz: Parantez içinde herhangi bir parametre almaz.

			// Metot tanımı
			void MetotAdi()
			{
				// Metot içindeki işlemler
				Console.WriteLine("Merhaba, bu bir metot örneğidir.");
			}

			void CizgiCiz()
			{
				Console.WriteLine(new string('-', 20)); // 20 adet "-" çiz
			}

			// Metodu çağır
			CizgiCiz();

			// Metot çağrısı
			MetotAdi();

			// 2.Kare Çizdirme:

			void KareCizdir()
			{
				for (int i = 0; i < 5; i++) // 5 satır çizmek için
				{
					for (int j = 0; j < 5; j++) // Her satıra 5 yıldız koymak için
					{
						Console.Write("* "); // Yıldızları yan yana yazdır
					}
					Console.WriteLine(); // Satır tamamlandığında bir alt satıra geç
				}
			}

			//KareCizdir();

			// Parametre alan geriye değer döndürmeyen metot 

			void DinamikKareCizdir(int boyut)
			{
				for (int i = 0; i < boyut; i++) // Satır sayısı
				{
					for (int j = 0; j < boyut; j++) // Sütun sayısı
					{
						Console.Write("* ");
					}
					Console.WriteLine(); // Satır sonu
				}
			}

			// Metot çağrısı
			DinamikKareCizdir(3); // 3x3 kare çizer

			void Topla(int sayi1, int sayi2)
			{
				int sonuc7 = sayi1 + sayi2;
				Console.WriteLine($"Toplam: {sonuc7}");
			}

			// Metot çağrısı
			Topla(10, 20); // Çıktı: Toplam: 30
			Topla(5, 15);  // Çıktı: Toplam: 20

			// Kullanıcıdan Aldığı İsmi Tekrarlama

			void IsimTekrar(string isim,int deger1)
			{
				for(int i = 1;i <= deger1;i++)
				{
                    Console.WriteLine($"isim : {isim}");
				}
			}
			IsimTekrar("berkan", 3);

			// Parametre alan geriye değer döndüren metotlar :

			// Metot tanımı
			int Topla1(int sayi1, int sayi2)
			{
				int sonuc8 = sayi1 + sayi2;
				return sonuc8; // Sonucu geriye döndür
			}

			// Metot çağrısı
			int toplam = Topla1(10, 20); // 10 ve 20'yi topla, sonucu değişkene ata
			Console.WriteLine($"Toplam: {toplam}"); // Çıktı: Toplam: 30


			double KareAl(double sayi)
			{
				return sayi * sayi; // Geriye sayının karesini döndür
			}

			// Metot çağrısı
			double sonuc = KareAl(5); // 5'in karesini hesaplar
			Console.WriteLine($"Sonuç: {sonuc}"); // Çıktı: Sonuç: 25


			// Asal Sayı Kontrolü 

			bool AsalMi(int sayi)
			{
				if (sayi < 2) return false; // 2'den küçük sayılar asal değildir

				for (int i = 2; i <= Math.Sqrt(sayi); i++) // 2'den √sayi'ya kadar kontrol et
				{
					if (sayi % i == 0) return false; // Tam bölünme varsa asal değil
				}

				return true; // Hiç bölünme yoksa asal
			}

            // Metot çağrısı
            Console.WriteLine("Denemek İstedeğiniz sayıyı giriniz");
			int deger = Convert.ToInt32(Console.ReadLine());

			
			if (AsalMi(deger))
				Console.WriteLine($"{deger} bir asal sayıdır.");
			else
				Console.WriteLine($"{deger} bir asal sayı değildir.");

			 int RastgeleSayiUret()
			{
				Random random = new Random();
				return random.Next(1, 101); // 1 ile 100 arasında bir sayı döndürür
			}

			int rastgeleSayi = RastgeleSayiUret();
			Console.WriteLine($"Üretilen Rastgele Sayı: {rastgeleSayi}");


			Console.ReadLine();

		}
	}
}
