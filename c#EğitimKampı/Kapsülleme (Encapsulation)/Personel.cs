using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme__Encapsulation_
{
	internal class Personel
	{
		private string tckimlikno;


		public string TCKIMLIKNO
		{
			get {

				return tckimlikno.Substring(0, 5)+"******";
			
			}
			set
			{
				bool kontrol = false;
				if (value.Length == 11)
				{
					for (int i = 0; i < value.Length; i++)
					{
						bool sayiMi = char.IsNumber(value[i]);

						if (sayiMi)
						{
							// yapmamız gereken birşey yok 
						}
						else
						{
							kontrol = true;
							break;
						}
					}

					if (kontrol)
					{
						Console.WriteLine("Lütfen tc kimlik numaranızda geçersszi karakter bulundu");
					}
					else
					{
						tckimlikno = value;
					}




				}
				else
				{
					Console.WriteLine("Girdiğiniz tc kimlik no 11 karakter değildir");
				}
			}
		}

	}
}
