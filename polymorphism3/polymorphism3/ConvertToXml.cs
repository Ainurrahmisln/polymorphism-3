using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

namespace polymorphism3
{
    public class ConvertToXml : IConverObject
    {
        private object writer;

        public void Convert(TokoSembako toko)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TokoSembako));
            serializer.Serialize((System.Xml.XmlWriter)writer, toko);

            string xml = writer.ToString();

            Console.WriteLine("Hasil konversi ke XML:\n");
            Console.WriteLine(xml);

            throw new NotImplementedException();
        }
    }
}
