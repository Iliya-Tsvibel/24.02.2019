using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car[] otos =
            //    {new Car("mitzubisi", 6, 2015, "metalic", 6758, 6),
            //     new Car("toyota",5,1600,"black",2500,7),
            //     new Car("lada",5,2009,"red",2700,5)};

            XmlSerializer myxmlSerializer = new XmlSerializer(typeof(Car[]));
            //using (Stream file = new FileStream(@"c:\temp\IliyaCar.xml", FileMode.Create))
            //{
            //    myxmlSerializer.Serialize(file, otos);
            //} // auto-closing the string
            //PrintArray(otos);
            Car[] otos2;

            using (Stream file = new FileStream(@"c:\temp\IliyaCar.xml", FileMode.Open))
            {
                otos2 = myxmlSerializer.Deserialize(file) as Car[];
            } // auto-closing the string
            PrintArray(otos2);
        }
        static void PrintArray(Car[] c)
        {
            foreach (Car oto in c)
            {
                Console.WriteLine(oto);
            }
        }
    }
}
