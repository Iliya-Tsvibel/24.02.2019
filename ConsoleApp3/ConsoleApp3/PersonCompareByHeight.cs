using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PersonCompareByHeight : IComparer<Person>
    {
        public int Compare(Person a, Person b)
        {
            return Convert.ToInt32(a.Height - b.Height);
        }

    }
}
