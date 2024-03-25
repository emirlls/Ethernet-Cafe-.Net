using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kafe3
{
    public class XmlHelper
    {
        public static List<MasaBilgisi> Oku(string dosyaYolu)
        {
            if (File.Exists(dosyaYolu))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<MasaBilgisi>));
                using (FileStream fileStream = new FileStream(dosyaYolu, FileMode.Open))
                {
                    return (List<MasaBilgisi>)serializer.Deserialize(fileStream);
                }
            }
            else
            {
                return new List<MasaBilgisi>();
            }
        }

        public static void Yaz(List<MasaBilgisi> masaBilgileri, string dosyaYolu)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<MasaBilgisi>));
            using (FileStream fileStream = new FileStream(dosyaYolu, FileMode.Create))
            {
                serializer.Serialize(fileStream, masaBilgileri);
            }
        }
    }
}
