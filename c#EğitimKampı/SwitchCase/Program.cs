using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// Switch-Case'in Yapısı:
			/*
			 switch (değişken)
{
				case değer1:
					// Eğer değişken değer1 ile eşleşiyorsa bu kod çalışır
					break;
				case değer2:
					// Eğer değişken değer2 ile eşleşiyorsa bu kod çalışır
					break;
				default:
					// Hiçbir durum sağlanmazsa bu kod çalışır
					break;
}
			 */




			// Örnek 1 

			// Kullanıcıdan bir sayı isteyin. Eğer sayı 1 ise "Bir", 2 ise "İki", 3 ise "Üç" yazdırın.
			// Diğer sayılar için "Bilinmeyen Sayı" yazdırın.

			bool deger = true;

			while (deger)
			{
				Console.WriteLine("Bir sayı girin:");
				int sayi = Convert.ToInt32(Console.ReadLine());

				switch (sayi)
				{
					case 1:
						Console.WriteLine("Bir");
						break;

					case 2:
						Console.WriteLine("İki");
						break;

					case 3:
						Console.WriteLine("Üç");
						break;

					default:
						Console.WriteLine($"Geçersiz sayı yazıldı: {sayi}");
						Console.WriteLine("Çıkılıyor...");
						Console.ReadLine();
						deger = false; // Döngüden çıkmak için kontrol değişkenini false yapıyoruz
						break;
				}
			}


			// Zor Uygulama: Basit Hesap Makinesi


			Console.Write("Birinci sayıyı girin: ");
			double sayi1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("İkinci sayıyı girin: ");
			double sayi2 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Bir işlem türü seçin (+, -, *, /): ");
			char islem = Convert.ToChar(Console.ReadLine());

			switch (islem)
			{
				case '+':
					Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
					Console.ReadLine();
					break;
					
				case '-':
					Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
					Console.ReadLine();
					break;
				case '*':
					Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
					Console.ReadLine();
					break;
				case '/':
					if (sayi2 != 0)
					{
						Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
						Console.ReadLine();
					}
					else
					{
						Console.WriteLine("Hata: Bir sayı 0'a bölünemez!");
					}
					break;
				default:
					Console.WriteLine("Geçersiz işlem türü!");
					break;
			}









		}
	}
}
