using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Polymorphism2
{
    public class ITokoSembako
    {
        public string Name { get; set; }
        public string Gula { get; set; }
        public string Garam { get; set; }
        public string Beras { get; set; }

        public virtual void Tempat()
        {
            Console.WriteLine("The Toko Sembako Tempat");
        }

        internal static int Equals(Func<string> readLine)
        {
            throw new NotImplementedException();
        }

        internal static double Totalbarang()
        {
            throw new NotImplementedException();
        }

        internal static double TotalPembelian()
        {
            throw new NotImplementedException();
        }

        internal void Tempat(ITokoSembako toko)
        {
            throw new NotImplementedException();
        }
    }
}
