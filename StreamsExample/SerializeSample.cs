using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace StreamsExample
{
    internal class SerializeSample
    {
        public void SerializeXml()
        {
            var persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "John",
                    Age=21
                },
                new Person
                {
                    Id = 2,
                    Name = "Mariah",
                    Age=21
                },
                new Person
                {
                    Id = 3,
                    Name = "Louis",
                    Age=25
                },
            };

            var filePath = "persons.xml";

            var xmlserializer = new XmlSerializer(typeof(List<Person>));

            using FileStream fs = new FileStream(filePath, FileMode.Open);
            
                xmlserializer.Serialize(fs, persons);

            
        }

        public void SerializeJson()
        {
            var persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "John",
                    Age=21
                },
                new Person
                {
                    Id = 2,
                    Name = "Mariah",
                    Age=21
                },
                new Person
                {
                    Id = 3,
                    Name = "Louis",
                    Age=25
                },
            };

            var filePath = "persons.json";

            var json = JsonSerializer.Serialize(persons);

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(json);
                fs.Write(buffer);
            }
        }

        public void DeserializeJson()
        {
            var filePath = "persons.json";
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[(int)fs.Length];

                fs.Read(buffer);

                var json = Encoding.Default.GetString(buffer);
                var persons = JsonSerializer.Deserialize<List<Person>>(json);

                foreach(var p in persons)
                {
                    Console.WriteLine($"{p.Id}. {p.Name} {p.Age}");
                }
            }
        }
    }

    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
