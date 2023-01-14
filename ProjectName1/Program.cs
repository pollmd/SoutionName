using GeneralLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person
                {
                    id = 1,
                    Name = "Ion",
                    Age=20
                },
                new Person
                {
                    id = 2,
                    Name = "Maria",
                    Age=30
                },
                new Person
                {
                    id = 3,
                    Name = "Victoria",
                    Age=40
                }
            };

            var shortList = persons.Where(x => x.id <= 2);

            //var 

            foreach (var person in shortList)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
