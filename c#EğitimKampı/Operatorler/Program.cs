using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  Operatörler 

			// 1- Aritmetik Operatörler

			/*
			Ekleme(+) kavramı string değerleri birleştirir, sayısal değerleri ise toplar.
			Çıkarma(-) işlemi için kullanılır.
			Çarpma(*) işlemi için kullanılır.
			Bölme(/) işlemi için kullanılır.
			Mod Alma(%) bölme işleminde ortaya çıkan kalan değerini elde etmek için kullanırız.


			*/

			// Değişken Tanımlaması:
			int x = 2021, y = 5, z = 8;
			string webSite = "www.emrecelen.com.tr", webText = "Web Sitem: ";
			//Aritmetik Operatör Kullanımları:
			Console.WriteLine(new string('-', 20) + "\n-> C# Aritmetik Operatör Örnekleri");
			Console.WriteLine("-> X + Y = " + (x + y) + "\t- Toplama Operatörü"); // Toplama Operatör Kullanımı
			Console.WriteLine("-> Z - X = " + (z - x) + "\t- Çıkartma Operatörü"); // Çıkartma Operatör Kullanımı
			Console.WriteLine("-> Z * Y = " + (z * y) + "\t- Çarpma Operatörü"); // Çarpma Operatör Kullanımı
			Console.WriteLine("-> X / Y = " + (x / y) + "\t- Bölme Operatörü"); // Bölme Operatör Kullanımı
			Console.WriteLine("-> X % Y = " + (x % y) + "\t- Mod Alma Operatörü"); // Mod Alma Operatör Kullanımı
			Console.WriteLine(new string('-', 20));
			Console.WriteLine(webText + webSite); // String metinleri birleştirme için (+) operatör kullanımı


			// 2- Tekli Operatörler

			//Tekli + veya - konulması, operand içerisindeki sayısal değeri negatif veya pozitif yapmak için kullanılır.
			//Arttırma ve Azaltma Operatörü(++ / --) operandın değerini bir arttırır veya bir azaltır ve iki türlü kullanım şekli vardır bu kullanım şekillerini aşağıdaki maddelerde belirttim.
			//Sonrasında Artış veya Azalış(x++ / x--) operand önce hesaplanır sonra arttırılma işlemi gerçekleştirilir.
			//Ön Arttırma veya Azaltma(++x / --x) operand önce arttırılır veya azaltılarak hesaplanması gerçekleştirilir.
			//Değil Operatörü(!) boolean içerisinde bulunan değeri ters çevirmek için kullanılır.

			// Değişken Tanımlaması:
			int a = 5, b = 5, x1 = 10, y1= 10;
			bool neyimBen = true;
			// Tekli Operatör Kullanımı:
			Console.WriteLine(new string('-', 20) + "\n-> Başlangıç (A) Değeri: {0} -- Başlangıç (B) Değeri: {1}", a, b);
			Console.WriteLine("-> (A++) Kullanımı: {0} -- (++B) Kullanımı: {1}", a++, ++b);
			Console.WriteLine(new string('-', 20) + "\n-> Başlangıç (X) Değeri: {0} -- Başlangıç (Y) Değeri: {1}", x, y);
			Console.WriteLine("-> (X--) Kullanımı: {0} -- (--Y) Kullanımı: {1}", x--, --y);
			Console.WriteLine(new string('-', 20) + "\n-> Başlangıç (neyimBen) Değeri: " + neyimBen);
			Console.WriteLine("-> (!neyimBen) Kullanımı:" + !neyimBen);
			Console.WriteLine(new string('-', 20));
			Console.ReadLine();



			// 3- Atama Operatörleri

			//   C# Kategorisinde ilk konumuz olan C# Veri Tipleri ve Değişken Tanımlama içeriğinde sıklıkla kullandığımız operatör türüdür. Değişkenlere eleman atamak veya operand içerisindeki veriyi işleme tabi tutmak için kullanılır. Bu işlemler aritmetik operatörler ile aynı sonuçları vermektedir daha detaylı analiz gerçekleştirmek için aşağıdaki maddelerde C# Atama Operatörlerine göz atabiliriz.

			//= Operatörü: Programlamaya ilk başladığınız zaman bir değişken tanımlarken veya bir sınıfı nesne olarak tanımlarken muhakkak kullandığımız temel atama operatörüdür.
			//+= Operatörü: Solda yer alan değere, kendi değerini ekleyerek tekrar soldaki değere atama işlemini gerçekleştirir.
			//-= Operatörü: Sol tarafta bulunan değerden, sağda bulunan değeri çıkararak tekrar solda bulunan değere atama işlemini gerçekleştirir.
			//*= Operatörü: Eşittir solunda yer alan değeri, sağda yer alana değer ile çarparak tekrar solda bulunan değere atamasını gerçekleştirir.
			///= Operatörü: Yukarıda yer alan atama operatörlerinde olduğu gibi soldaki değeri, sağdaki değere böler ve tekrardan a tama işlemini gerçekleştirir.

			// Değişken Tanımlaması:
			int degisken = 15;
			// Atama Operatör Kullanımı:
			Console.WriteLine(new string('-', 20) + "\n-> C# Atama Operatör Örnekleri");
			Console.WriteLine("-> [{0}] degisken += 5 Sonucu: {1}", degisken, (degisken += 5));
			Console.WriteLine("-> [{0}] degisken -= 12 Sonucu: {1}", degisken, (degisken -= 12));
			Console.WriteLine("-> [{0}] degisken *= 2 Sonucu: {1}", degisken, (degisken *= 2));
			Console.WriteLine("-> [{0}] degisken /= 4 Sonucu: {1}", degisken, (degisken /= 4));
			Console.WriteLine(new string('-', 20));

			// 4- İlişkisel Operatör

			//C# Operatörler kavramı içerisinde en çok kullanacağımız operatör türü İlişkisel Operatörlerdir. İlişkisel operatörler, değişkenler içerisinde bulunan elemanların veya harici tanımlanan operand değerlerin karşılaştırmasını gerçekleştirir. Bu karşılaştırma sonucunda dönen değer boolean türünde true veya false‘dur.

			//Küçüktür(<)
			//Büyüktür(>)
			//Küçük Eşittir(<=)
			//Büyük Eşittir(>=)
			//Eşittir(==)
			//Eşit Değildir(!=)


			// 5- Mantıksal Operatörler
			//&(ve)Mantıksal Operatörü: Değişken üzerinde tanımlı değeri veya operand üzerindeki gerçekleştirilecek kontroller için uygulanacak sorgulamaya veya işlemlere tabi tutar.
			//| (veya)Mantıksal Operatörü: İşlem esnasında iki kontrol yapısından birisinin koşuluna odaklanır.
			//&& (koşullu ve) Mantıksal Operatörü: Karşılaştırmalar esnasında tabi tutulan iki değişkenin veya operandın true olduğu durumlarda işlem gerçekleştirilir.
			//|| (koşullu veya) Mantıksal Operatörü: Tekli veya mantıksal operatöründe olduğu gibi iki değerden en az biri true olduğu sürece işlemleri uygulamaya devam eder.
			//!(değil)Mantıksal Operatörü: Elde edilen boolean veri türündeki değerin tersini alır.


			// Değişken Tanımlaması:
			string kAdi, pass;
			string kullaniciAdi = "emrecelen", sifre = "root123";
			Console.WriteLine(new string('-', 20) + "\n-> C# Mantıksal Operatör Örneği");
			Console.Write("-> Kullanıcı Adını Girin: ");
			kAdi = Console.ReadLine();
			Console.Write("-> Şifrenizi Girin: ");
			pass = Console.ReadLine();
			Console.WriteLine(new string('-', 20));
			if (kullaniciAdi.Equals(kAdi) && sifre.Equals(pass))
				Console.WriteLine("-> Giriş Başarılı.");
			else
				Console.WriteLine("-> Hatalı Giriş Yaptınız.");



		}
	}
}
