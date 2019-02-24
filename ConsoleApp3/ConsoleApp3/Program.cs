using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons =
            {
                new Person(6,23, 184, "Boris"),
                new Person(3,17, 176, "Moshe"),
                new Person(7,45, 185, "Yuda"),
                new Person(3,35, 197, "Izik"),
                new Person(3,38, 189, "Iliya")
            };
            PrintPersArray(persons);
            Array.Sort(persons);
            Console.WriteLine("Sort by ID");
            PrintPersArray(persons);
            Array.Sort(persons, new PersonCompareByName());
            Console.WriteLine("Sort by Name");
            PrintPersArray(persons);
            Array.Sort(persons, new PersonCompareByHeight());
            Console.WriteLine("Sort by Height");
            PrintPersArray(persons);
            Array.Sort(persons, new PersonCompareByAge());
            Console.WriteLine("Sort by Age");
            PrintPersArray(persons);
            Array.Sort(persons, new PersonCompareByID());
            Console.WriteLine("Sort by Id");
            PrintPersArray(persons);
            Array.Sort(persons, Person.nameComparer);
            Console.WriteLine("Sort by Name");
            PrintPersArray(persons);
            Array.Sort(persons, Person.idComparer);
            Console.WriteLine("Sort by ID");
            PrintPersArray(persons);
            Array.Sort(persons, Person.ageComparer);
            Console.WriteLine("Sort by Age");
            PrintPersArray(persons);
            Array.Sort(persons, Person.heightComparer);
            Console.WriteLine("Sort by Height");
            PrintPersArray(persons);
            Array.Sort(persons);
            Console.WriteLine("Sort by Id");
            PrintPersArray(persons);
            Person.ModDefComparer("Name");
            Array.Sort(persons);
            Console.WriteLine("Sort by Name");
            PrintPersArray(persons);

            Console.ReadKey();
        }
        static void PrintPersArray(Person[] perssonArr)
        {
            foreach (Person personItem in perssonArr)
            {
                Console.WriteLine(personItem);
            }
        }
    }
}
