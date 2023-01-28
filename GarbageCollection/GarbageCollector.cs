using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    public class GarbageCollector
    {
        public void Run()
        {
            Console.WriteLine($"Maximum generation {GC.MaxGeneration}");
            GarbageHelper hlp = new GarbageHelper();

            Console.WriteLine($"GarbageHelper generation {GC.GetGeneration(hlp)}");
            Console.WriteLine($"Memory used {GC.GetTotalMemory(false)}");
            hlp.MakeGarbage();
            Console.WriteLine($"Memory used {GC.GetTotalMemory(false)}");

            GC.Collect(0);
            Console.WriteLine($"Memory used {GC.GetTotalMemory(false)}");
            GC.Collect();
            Console.WriteLine($"Memory used {GC.GetTotalMemory(false)}");
        }
    }

    class GarbageHelper
    {
        public void MakeGarbage()
        {
            for (int i = 0; i < 10000; i++)
            {
                Person p = new Person();
            }
        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime BirthDate { get; set; }
        }
    }
}
