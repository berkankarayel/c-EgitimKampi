using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARYlst
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ArrayList list = new ArrayList();
			list.Add(1); // ad metodu değer ekleme 
			list.Add("Merhaba");
			list.Add(3.14);
			list.Remove(1); // remove metodu değer kaldırır.
			int count = list.Count; // count kaç eleman olduğunu gösterir. 
			bool kontrol = list.Contains(1); // içinde var mı yok mu kontro eder
			int nuber = list.IndexOf(3.14); // index numarasını verme 
			list.Insert(1,"Deneme");// 1. indexse ekleme yaptı
			list.Reverse();// diziyi ters çevirir.

			// sort metodu kullanımı 

			// rakamlar.sort() diziy küçükten büyüğe sıralar.

			

			// ArrayList öğelerini yazdırma
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
            Console.WriteLine(count);
            Console.WriteLine(kontrol);
            Console.WriteLine(nuber);
			Console.ReadLine();
		}
	}
}
