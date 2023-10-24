using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenci
{
    internal class Personal
    {
        string ad;
        public string Ad
        {
            get => ad;
            set => ad = value;
        }
        int yas;
        public int Yas
        {
            get => yas;
            set => yas = value;
        }
        int no;
        public int No
        {
            get => no;
            set => no = value;
        }
        string adres;
        public string Adres
        {
            get => adres; set => adres = value;
        }
    }
}
