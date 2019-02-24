using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PersonCompareByID : IComparer<Person>
    {
        public int Compare(Person a, Person b)
        {
            return a.Id - b.Id;
        }

    }
}
