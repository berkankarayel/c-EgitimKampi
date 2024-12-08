using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_YapıcıMetot_
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Yapıcı metotlar, bir sınıftan nesne oluşturulduğunda otomatik olarak çalışan özel metotlardır.
			//Sınıfın adını taşır ve geri dönüş tipi yoktur.
			//Genellikle bir nesneye başlangıç değerleri atamak için kullanılır.


			Console.WriteLine("Lütfen araba kapi sayisini girniz");
			int KS = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Araba Modelini giriniz");
			string Am = Console.ReadLine();


			Araba araba = new Araba(KS,Am); // yapıcı metot çalıştı ve ilk onu yazdırdı. 

            Console.WriteLine("kapi sayisi : " + araba.kapiSayisi);
            Console.WriteLine("araba model :" + araba.Model);

			Console.ReadLine();

		}
	}
}
