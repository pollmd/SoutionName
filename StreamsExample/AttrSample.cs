using System;
using System.Collections.Generic;
using System.Text;

namespace StreamsExample
{
    internal class AttrSampleAttribute : Attribute
    {
        string Name = "Test";
        DateTime _date = DateTime.Now;

        public AttrSampleAttribute(string name, string date)
        {
            try
            {
                Name = name;
                _date = Convert.ToDateTime(date);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Person1
    {
        public string Name { get; set; }
        public DateTime _date;

        [AttrSample("Ion", "01/01/2020")]
        public void Test()
        {
            int i = 0;
        }

    }

}
