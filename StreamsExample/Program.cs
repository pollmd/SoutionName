using System;
using System.IO;
using System.Text;

namespace StreamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = "log.txt";
            using (FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate))
            {
                //BinaryWriter bw = new BinaryWriter(fs);
                //string inputText = Console.ReadLine();

                //int number = 1235;

                //bw.Write(inputText);
                //bw.Write(number);


                RegexExample.EmailPattern();



            }
        }


    }
}
