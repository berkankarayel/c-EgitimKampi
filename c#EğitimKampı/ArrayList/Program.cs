using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ArrayList list = new ArrayList();
			list.Add(1);
			list.Add("Merhaba");
			list.Add(3.14);

			// ArrayList öğelerini yazdırma
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}



		}
	}
}
