using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Sınıftan bir nesne oluşturuyoruz
			Araba araba1 = new Araba();
			araba1.Marka = "Toyota";
			araba1.Model = "Corolla";
			araba1.Yil = 2020;

			// Bilgi yazdırma metodunu çağırıyoruz
			araba1.BilgiYazdir();

			// Yeni bir araba oluşturabiliriz
			Araba araba2 = new Araba();
			araba2.Marka = "Honda";
			araba2.Model = "Civic";
			araba2.Yil = 2019;

			araba2.BilgiYazdir();

			Urun urun1 = new Urun();
			urun1.Ad = "Telefon";
			urun1.Fiyat = 15000;

			Urun urun2 = new Urun();
			urun2.Ad = "Bilgisayar";
			urun2.Fiyat = 25000;

			urun1.BilgiYazdir();
			urun2.BilgiYazdir();

			double toplamFiyat = urun1.Fiyat + urun2.Fiyat;
			Console.WriteLine($"Toplam Tutar: {toplamFiyat} TL");
			Console.ReadLine();
		}
	}
}
