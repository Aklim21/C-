using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
    {
        //fields
        public string LastName;
        public string FirstName;
        public DateTime DateofBirth;
        public WondersOfTheWorld FavouriteAncientWonder;
        public WondersOfTheWorld BucketList;
        public List<Person> Children = new List<Person>();



    }
}
