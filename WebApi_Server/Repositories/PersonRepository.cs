using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebApi_Common.Models;

namespace WebApi_Server.Repositories
{
    public static class PersonRepository
    {
        private const string filename = "People.json";

        public static IEnumerable<Person> GetPeople()
        {
            if (File.Exists(filename))
            {
                var rawData = File.ReadAllText(filename);
                var people = JsonSerializer.Deserialize<IEnumerable<Person>>(rawData);
                return people;
            }

            return new List<Person>();
        }

        public static void StorePeople(IEnumerable<Person> people)
        {
            var rawData = JsonSerializer.Serialize(people);
            File.WriteAllText(filename, rawData);
        }
    }
}
