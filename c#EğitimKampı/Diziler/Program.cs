using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int[] sayilar = new int[5]; // 5 elemanlı bir dizi oluşturur. 


			int[] sayilar1 = { 10, 20, 30 };

			int[] sayilar2 = new int[3];
			sayilar2[0] = 5; // 1. eleman
			sayilar2[1] = 10; // 2. eleman
			sayilar2[2] = 15; // 3. eleman

			// Tüm Elemanları Döngü ile Yazdırma


			int[] sayilar3 = { 5, 10, 15, 20, 25 };
			

			for (int i = 0; i < sayilar3.Length; i++) // sayilar.Length dizinin uzunluğunu verir
			{
				Console.WriteLine($"Eleman {i + 1}: {sayilar3[i]}");
			}


			// Örnek: Kullanıcıdan Veri Alarak Diziye Atama

			int[] sayilar4 = new int[5]; // 5 elemanlı bir dizi

			

			Console.WriteLine("Lütfen 5 sayı girin:");
			for (int i = 0; i < sayilar4.Length; i++)
			{
				Console.Write($"Sayı {i + 1}: ");
				sayilar4[i] = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan veri alıyoruz
			}

			Console.WriteLine("Girdiğiniz sayılar:");
			for (int i = 0; i < sayilar4.Length; i++)
			{
				Console.WriteLine($"Sayı {i + 1}: {sayilar4[i]}");
			}

			Console.ReadLine();


			// Örnek 1: Dizideki Elemanları Yazdırma

			int[] sayilar5 = { 10, 20, 30, 40, 50 };

			Console.WriteLine("Dizideki elemanlar:");
			foreach (int sayi in sayilar5)
			{
				Console.WriteLine(sayi); // Her bir eleman yazdırılır
			}



		}
	}
}
