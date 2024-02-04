using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace polymorphism3
{
    class ConverToJson : IConverObject
    {
        public void Convert(TokoSembako toko)
        {
            string json = JsonConvert.SerializeObject(toko);

            Console.WriteLine("Hasil konversi ke json:\n");
            Console.WriteLine(json);

            throw new NotImplementedException();
        }
    }
}
