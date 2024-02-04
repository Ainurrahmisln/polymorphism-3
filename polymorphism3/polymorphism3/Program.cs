using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism3
{
    public class Program
    {
        static void Main(string[] args)
        {
            TokoSembako toko = new TokoSembako();
            toko.nama = " imaa ";
            toko.barang = "kopi";
            toko.jumlah = "2 bungkus";

            Console.WriteLine("pilihan format konversi data pembeli:");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv\n");

            Console.Write("Nomor Format Data [1..3]: ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IConverObject convert;

            if (nomorFormatData == 1)
                convert = new ConverToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();

            convert.Convert(toko);

            Console.ReadKey();
        }
    }
}
