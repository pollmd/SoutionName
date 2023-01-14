using System;

namespace GeneralLibrary
{
    public class Person
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{id}. {Name} - {Age}";
        }
    }
}
