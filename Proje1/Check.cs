using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public class Check : Odeme
    {
        public string Name { get; set; }
        public string BankID { get; set; }


        public string Onaylama()
        {
            return "Onaylandı";
        }
    }
}
