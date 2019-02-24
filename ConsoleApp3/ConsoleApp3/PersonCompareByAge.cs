using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PersonCompareByAge : IComparer<Person>
    {
        public int Compare(Person a, Person b)
        {
            return a.Age - b.Age;
        }

    }
}
