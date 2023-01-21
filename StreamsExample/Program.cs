using System;
using System.IO;
using System.Text;

namespace StreamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var filePath = "log.txt";
            //using (FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate))
            //{


            //}

            var obj = new SerializeSample();
            obj.SerializeJson();
        }


    }
}
