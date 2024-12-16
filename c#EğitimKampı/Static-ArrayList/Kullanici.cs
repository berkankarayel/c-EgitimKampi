using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_ArrayList
{
	internal class Kullanici
	{
        private int KullaniciId { get; set; }
        private string isim { get; set; }

       private string soyisim { get; set; }

      private  static int maas { get; set; }

		// Static Yapıcı Metotlar ; 

		// 1- Static yapıcı metot erişim belirleyici kullanamaz
		// 2  static yapıcı metot parametre almaz 
		// ilk static yapıcı metot çalışır.
		//  static yapıcı metot 1 kere çalışır
		// bir sınıf sadece 1 adet static yapıcı metot içerebilir. 

		static Kullanici()
        {
            maas = 2500;
        }

        public Kullanici(int _kullaniciId,string _isim,string _soyisim) // yapıcı metot oluşturuldu 
        {
           KullaniciId = _kullaniciId;
            isim = _isim;
            soyisim = _soyisim;
          
        }


        public void bilgileriGoster()
        {
            Console.WriteLine("kullanıcı bilgiler");
            Console.WriteLine(KullaniciId);
            Console.WriteLine(isim);
            Console.WriteLine(soyisim);
            Console.WriteLine(maas);
        }

        public void zamYap(int zamMiktarı)
        {
            Console.WriteLine("zam yapılıyor ");
            Console.WriteLine("yeni maaş"+(maas+zamMiktarı));
        }
    }
}
