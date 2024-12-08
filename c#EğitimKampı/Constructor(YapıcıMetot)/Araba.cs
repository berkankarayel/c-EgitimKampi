using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_YapıcıMetot_
{
	internal class Araba
	{

		public int kapiSayisi;
        public string Model;

        public Araba(int _kapiSayisi,string _Model)
        {
            kapiSayisi = _kapiSayisi;
            Model = _Model;
        }


    }
}
