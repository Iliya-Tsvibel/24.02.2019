using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person : IComparable<Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }

        public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }

      
        public int CompareTo(Person another)
        {
            if (defComparerName is PersonCompareByID)
                return this.Id - another.Id;
            else if (defComparerName is PersonCompareByName)
                return String.Compare(this.Name, another.Name);
            else if (defComparerName is PersonCompareByHeight)
                return Convert.ToInt32(this.Height - another.Height);
            else if (defComparerName is PersonCompareByAge)
                return this.Age - another.Age;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"Id : {Id}, Age : {Age}, Height : {Height}, Name is: {Name}";
        }

           
        static IComparer<Person> defComparerName = new PersonCompareByName();

        private static readonly IComparer<Person> _idComparer;
        private static readonly IComparer<Person> _ageComparer;
        private static readonly IComparer<Person> _heightComparer;
        private static readonly IComparer<Person> _nameComparer;

        public static IComparer<Person> idComparer
        {
            get
            {
                return _idComparer;
            }
        }
        public static IComparer<Person> ageComparer
        {
            get
            {
                return _ageComparer;
            }
        }
        public static IComparer<Person> heightComparer
        {
            get
            {
                return _heightComparer;
            }
        }
        public static IComparer<Person> nameComparer
        {
            get
            {
                return _nameComparer;
            }
        }

        static Person()
        {
            _idComparer = new PersonCompareByID();
            _ageComparer = new PersonCompareByAge();
            _heightComparer = new PersonCompareByHeight();
            _nameComparer = new PersonCompareByName();
        }

        private static IComparer<Person> DefComparer()
        {
            return defComparerName;
        }

        public static void ModDefComparer(string Comparer)
        {
            switch (Comparer)
            {
                case ("Name"):
                    defComparerName = new PersonCompareByName();
                    break;
                case ("Height"):
                    defComparerName = new PersonCompareByHeight();
                    break;
                case ("Age"):
                    defComparerName = new PersonCompareByAge();
                    break;
                case ("Id"):
                    defComparerName = new PersonCompareByID();
                    break;
            }
        }

    }
}
