using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Veri Tipleri ; 
			/*
			Değişken tanımlarken dikkat edilmesi gereken bazı hususlar şu şekilde:

			Değişkenler case sensitive yani büyük küçük harf duyarlıdır.
			Değişken isimleri rakamlarla başlayamaz.
			Değişken isimleri boşluk içeremez. Yalnızca "_" ifadesi kullanılabilir.
			Değişken isimlerinin arasında matematiksel ifadeler yani 
			işlem operatörleri kullanılamaz.
			Class namespace gibi özel isimler kullanılamaz.
			Değişkenlerin her zaman bir değeri olmak zorundadır.
			Yoksa null tanımlanmalıdır.Ataması yapılmayan değişkenler 
			kullanıldığında derleyici hata verir.

			*/


			// Primitive Veri Tipler :ilker veri tipleridir. generl olarak sayısal 
			// veriler  tutumak için kullanılır. 

			/*
			 
				byte  :1 byte 
				sbyte  : 1 byte 
				short  : 2 byte 
				ushort  : 2 byte  
				integer  : 4 byte 
				uint  
				long  : 8 byte 
			    ulong  : 0 ile 2x2'63 arasındaki sayıları tutan veri tipidir. 
				
			 
			 
			 */

			// integers veri tipi : 


			int x = 1;
            Console.WriteLine(x);

            Console.WriteLine("int maksimum değer : " + int.MaxValue);
            Console.WriteLine("int minumum değer : "+ int.MinValue);

			string str20 = "20";
			int int20 = 20;

			string yeniDeger = str20+ int20.ToString();
            Console.WriteLine(yeniDeger); // output : 2020

			int yenideger2 = int20 + Convert.ToInt32(str20);
			Console.WriteLine(yenideger2); // output : 40 
			//  Kayan Noktalı Sayılar (Floats)
			// ! yanına f veya F koyulmalıdır.

			float y = 4.232323232f;
			Console.WriteLine(y.ToString("F3")); // VİRGÜLDEN SONRA 3 basamak yazdırır. 
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
			


			//  Çift Kayan Noktalı Sayılar (Doubles)

			double z = 5.9;
			Console.WriteLine(z); // Çıktı: 5.9

			Console.WriteLine(double.MaxValue); // 1.7976931348623157E+308
			Console.WriteLine(double.MinValue); // -1.7976931348623157E+308

			// 4 - Uzun Tamsayılar(Longs) ve Decimal
			// Büyük tamsayılar için long, büyük ve hassas ondalık sayılar için
			// decimal kullanılır:

			long l = long.MaxValue;
			Console.WriteLine(l); // 9223372036854775807

			decimal d = decimal.MaxValue;
			Console.WriteLine(d); // 79228162514264337593543950335


			// 5- Karakterler ve Dizgiler


			char karakter = 'e';
			string ad = "Ahmet";
			string s1 = "";
			string s2 = null;
			string s3 = string.Empty;
			s3 = "berkan karabaş";
			


			// 6- var ve dynamic Anahtar Kelimeleri

			/*
			 
			C#'da, var anahtar kelimesi ile değişkenlerin türü derleme zamanında 
			belirlenirken, dynamic anahtar kelimesi ile değişkenlerin türü çalışma 
			zamanında belirlenir. 
			var ile tanımlanan değişkenlerin türü, 
			atanan ilk değere göre belirlenir ve sonrasında değiştirilemez. 
			dynamic ile tanımlanan değişkenlerde ise tür, programın çalışma
			zamanında değişebilir:
			 */


			var a = 5;
			Console.WriteLine(a); // Çıktı: 5

			dynamic b = "Merhaba";
			Console.WriteLine(b); // Çıktı: Merhaba
			b = 10;
			Console.WriteLine(b); // Çıktı: 10




			// 7- Sabitler (Constants) ile const Kullanımı


			// const anahtar kelimesi, değeri programın çalışması sırasında değişmeyecek
			// sabitleri tanımlamak için kullanılır. Örneğin, matematikte
			// pi sayısının değeri sabittir ve değişmez.Bu tür sabit bir değeri const
			// ile tanımlayabiliriz:

			const double pi = 3.14159;
			Console.WriteLine(pi); // Çıktı: 3.14159

			// 8- bool Kullanımı

			bool dogru = true;
			bool yanlis = false;

			Console.WriteLine(dogru);  // Çıktı: True
			Console.WriteLine(yanlis); // Çıktı: False



			DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
			Console.ReadLine();

			// onject veri tipinde tüm deüişkenler tanımlanabilir. 


			object o1 = "x";
			object o2 = 2;
			object o3 = 'y';
			object o4 = 4.3;

			int degiske4 = 5;
			string degisken4 = "merhaba";
			Console.WriteLine(degisken4);
			Console.ReadLine();


		}
	}
}
