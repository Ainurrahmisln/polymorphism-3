using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism3
{
    public class ConvertToCsv : IConverObject
    {
        public void Convert(TokoSembako toko)
        {
            string csv = string.Format("{0},{1},{2}", toko.nama, toko.barang, toko.jumlah);

            Console.WriteLine("Hasil konversi ke csv:\n");
            Console.WriteLine(csv);

            throw new NotImplementedException();
        }
    }
}
