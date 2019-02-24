using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PersonCompareByName : IComparer<Person>
    {
        public int Compare(Person a, Person b)
        {
            return String.Compare(a.Name, b.Name);
        }
    }
}
