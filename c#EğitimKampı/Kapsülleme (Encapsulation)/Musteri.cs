using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme__Encapsulation_
{
	internal class Musteri
	{
		//public int kilo;


		// Property nedir ? 

		//public int KiloD2 { get; set; } // fildan bir farkı yok açılmadı .


		private int kilo;

        public int KILO { 
		
			get
			{
				return kilo ;	
			}
			set
			{ 
				kilo = value;
			
			}
		
		}

		


    }
}
