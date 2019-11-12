using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public class Credit : Odeme
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public string expDate { get; set; }


        public string Onaylama()
        {
            return "Onaylandı";
        }
    }
}
