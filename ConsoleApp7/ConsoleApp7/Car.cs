using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp7
{
    public class Car
    {
        public string Model { get; set; }
        public int Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        private int codan;
        protected int numberOfSeats;


        public Car()
        {

        }
        public Car(string fileName)
        {
            Car oto;
            XmlSerializer iliyaxmlSerializer = new XmlSerializer(typeof(Car));
            using (Stream file = new FileStream($@"c:\{fileName}\IliyaCar.xml", FileMode.Open)) //link
            {
                oto = iliyaxmlSerializer.Deserialize(file) as Car;
            } // auto-closing the string
            this.Model = oto.Model;
            this.Brand = oto.Brand;
            this.Year = oto.Year;
            this.Color = oto.Color;
        }

        public Car(string model, int brand, int year, string color, int codan, int numberOfSeats)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            this.codan = codan;
            this.numberOfSeats = numberOfSeats;
        }
        public int MyCodan
        {
            get
            {
                return this.codan;
            }
        }
        public int NumberOfSeats
        {
            get
            {
                return this.numberOfSeats;
            }
        }
        protected void SetNumberOfSeats(int n)
        {
            this.numberOfSeats = n;
        }
        public static void SerializeACar(string fileName, Car car)
        {
            XmlSerializer myxmlSerializer = new XmlSerializer(typeof(Car));
            using (Stream file = new FileStream($@"c:\{fileName}\IliyaCar.xml", FileMode.Create))
            {
                myxmlSerializer.Serialize(file, car);
            } // auto-closing the string
        }
        public static void SerializeACarArray(string fileName, Car[] cars)
        {
            XmlSerializer myxmlSerializer = new XmlSerializer(typeof(Car[]));
            using (Stream file = new FileStream($@"c:\{fileName}\IliyaCarArray.xml", FileMode.Create))
            {
                myxmlSerializer.Serialize(file, cars);
            } // auto-closing the string
        }
        public static Car DeserializeACar(string fileName)
        {
            Car oto;
            XmlSerializer myxmlSerializer = new XmlSerializer(typeof(Car));
            using (Stream file = new FileStream($@"c:\{fileName}\IliyaCar.xml", FileMode.Open))
            {
                oto = myxmlSerializer.Deserialize(file) as Car;
            }
            return oto;
        }
        public static Car[] DeserializeACarArray(string fileName)
        {

            Car[] otos;
            XmlSerializer myxmlSerializer = new XmlSerializer(typeof(Car[]));
            using (Stream file = new FileStream($@"c:\{fileName}\IliyaCar.xml", FileMode.Open))
            {
                otos = myxmlSerializer.Deserialize(file) as Car[];
            }
            return otos;
        }
        //public bool CarCompare(string fileName)
        //{
          
        //}

        public override string ToString()
        {
            return $"Model of Car:{this.Model} Brand:{this.Brand} Year:{this.Year} Color:{this.Color} codan:{this.codan} Seats number:{this.numberOfSeats}";
        }
    }
}
