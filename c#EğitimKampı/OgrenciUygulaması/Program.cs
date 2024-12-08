using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulaması
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // Kullanıcıdan öğrenci bilgilerini al 

            Console.WriteLine("Öğrencinin adı : ");
			string isim = Console.ReadLine();

            Console.WriteLine("Öğrencinin Soyadı :");
			string soyisim = Console.ReadLine();

            Console.WriteLine("1. Vize Notu :");
			double vize1 = double.Parse(Console.ReadLine());

            Console.WriteLine("2. Vize Notu :");
			double vize2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Final Notu :");
			double final = double.Parse(Console.ReadLine());


            Console.WriteLine("Okul Adı :");
			string OkulIsmi = Console.ReadLine();


			Ogrenci ogrenci = new Ogrenci(isim,soyisim,vize1,vize2,final,OkulIsmi);


			while (true)
			{
				Console.WriteLine("\n--- MENÜ ---");
				Console.WriteLine("1. Öğrenci bilgilerini göster");
				Console.WriteLine("2. Öğrenci ortalamasını göster");
				Console.WriteLine("3. Öğrencinin okulunu öğren");
				Console.WriteLine("4. Çıkış yap");
				Console.Write("Seçiminizi yapın: ");
				string secim = Console.ReadLine();

				if (secim == "1")
				{
					ogrenci.OgrenciBilgileriGoster();

				}
				else if (secim == "2")
				{
					double ortalama = ogrenci.OgrenciOrtalamaBul();
					Console.WriteLine($"Öğrencin Ortalaması : {ortalama}");

				}
				else if (secim == "3") {

                    Console.WriteLine($"Öğrencinin Okulu : {OkulIsmi}");
				}
				else if (secim == "4")
				{
					Console.WriteLine("Programdan çıkılıyor...");
					break;
				}
				else
				{
					Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
				}




			}

			Console.ReadLine();
		}
	}
}
