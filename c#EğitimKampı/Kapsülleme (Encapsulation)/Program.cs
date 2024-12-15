using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme__Encapsulation_
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// Kapsülleme (Encapsulation), nesne tabanlı programlamada
			// (OOP) bir sınıfın (class) içerisindeki verileri dışarıdan
			// gelen doğrudan erişimlere karşı koruma altına alma yöntemidir.

			//Veri güvenliği sağlanır.
			//Sınıfın iç detaylarını gizler(gereksiz yere dış dünyaya açmaz).
			//Kullanıcı, sadece izin verilen metotlar aracılığıyla verilere erişebilir veya değiştirebilir.

			BankaHesabı hesap = new BankaHesabı(500); // 500 TL ile hesap oluşturuldu
			hesap.BakiyeGoster();   // Bakiye: 500 TL
			hesap.ParaYatir(200);   // 200 TL yatırıldı
			hesap.BakiyeGoster();   // Bakiye: 700 TL
			hesap.ParaCek(100);     // 100 TL çekildi
			hesap.BakiyeGoster();   // Bakiye: 600 TL
			


			// Getter: Bir değişkenin değerini dış dünyaya döndürür.
			//Setter: Değişkene dışarıdan değer atamaya izin verir.

			Ogrenci ogrenci = new Ogrenci();
			ogrenci.SetIsim("Ahmet"); // İsmi ayarla
			Console.WriteLine(ogrenci.GetIsim()); // İsmi göster

			Ogrenci ogrenci1 = new Ogrenci();
			ogrenci1.Isim1 = "Merve";
			ogrenci1.Yas1= 21;

			Console.WriteLine($"İsim: {ogrenci1.Isim1}, Yaş: {ogrenci1.Yas1}");


			Musteri musteri = new Musteri();
			musteri.KILO = 85; // değer ataması yaptık set çalıştı. 
            Console.WriteLine(musteri.KILO);// burdada get yapark değeri okuttuk .

			Personel P1 = new Personel();
			P1.TCKIMLIKNO = "17923232223";
            Console.WriteLine(P1.TCKIMLIKNO);
			Console.ReadLine();
		}
	}
}
