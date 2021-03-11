using System;
using System.Collections.Generic;
using static System.Console;

namespace Ch06_Library
{
    public partial class Person : IComparable<Person>
    {
        public int CompareTo(Person other)
        {
            throw new NotImplementedException();
        }
    }
}