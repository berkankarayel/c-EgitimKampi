using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_ArrayList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//eğer metot static ise obje oluşturmamıza gerek kalmaz clas
			// ismi üzerinden erişebirliz.

			 Personel.IsimSoyisimYazdir();

			Calisan c1 = new Calisan();
			c1.calisanId = 1;
			c1.isim = " Berkan";
			c1.soyisim = "Karayel";
			Calisan.maas = 2500;

			Console.WriteLine("Çalısan ID :" + c1.calisanId);
			Console.WriteLine("calisan isim :" + c1.isim);

			Console.WriteLine("calisan soyisim " + c1.soyisim);
			Console.WriteLine("calisan maaş " + Calisan.maas);


			Kullanici k1 = new Kullanici(1,"Berkan","Karayel");

			k1.bilgileriGoster();
			k1.zamYap(700);


			// Array List 

			string[] isimler = { "Berkan", "Sevil", "Buşra", "ahmet" };
			foreach (string s in isimler)
			{
                Console.WriteLine(s);
			}
			
			ArrayList koleksiyon = new ArrayList();
			koleksiyon.


			Console.ReadKey();
		}
	}
}
