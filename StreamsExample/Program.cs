using System;
using System.IO;
using System.Text;

namespace StreamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new SerializeSample();
            obj.DeserializeJson();
        }


    }
}
