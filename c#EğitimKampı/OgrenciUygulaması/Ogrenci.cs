using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulaması
{
	internal class Ogrenci
	{
		private int ogrNo;
		private string isim;
		private string soyisim;
		private double vize1;
		private double vize2;
		private double final;
		private string OkulIsmI;


        public Ogrenci(string isim,string soyisim, double vize1,double vize2,double final,string OkulIsmi)
        {
			Random random = new Random();
			int ilkUcHane = 201; // İlk üç hane sabit
			int sonUcHane = random.Next(100, 1000); // Rastgele 3 haneli sayı
			this.ogrNo = int.Parse($"{ilkUcHane}{sonUcHane}"); // 201xxx formatında öğrenci no
			this.isim = isim;
			this.soyisim = soyisim;
			this.vize1 = vize1;
			this.vize2 = vize2;
			this.final = final;
			this.OkulIsmI = OkulIsmi;
        }

		public void OgrenciBilgileriGoster()
		{
            Console.WriteLine("\n... Öğrenci Bilgileri .....");
            Console.WriteLine($"Öğrenci No: {ogrNo}");
            Console.WriteLine($"İsim : {isim}");
            Console.WriteLine($"Soyisim : {soyisim}");
            Console.WriteLine($"Okul: {OkulIsmI}");


		}

		public double OgrenciOrtalamaBul()
		{
			return (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);
		}

		public string OkulGetir()
		{
			return OkulIsmI;
		}

    }
}
