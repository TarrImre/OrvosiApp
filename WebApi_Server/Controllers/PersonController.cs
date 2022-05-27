using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi_Common.Models;
using WebApi_Server.Repositories;

namespace WebApi_Server.Controllers
{
    [ApiController]
    [Route("api/person")]
    public class PersonController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            var people = PersonRepository.GetPeople();
            return Ok(people);
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var people = PersonRepository.GetPeople();

            var person = people.FirstOrDefault(x => x.Id == id);
            if (person != null)
            {
                return Ok(person);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody]Person person)
        {
            var people = PersonRepository.GetPeople().ToList();

            person.Id = GetNewId(people);
            people.Add(person);

            PersonRepository.StorePeople(people);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Person person)
        {
            var people = PersonRepository.GetPeople().ToList();

            var personToUpdate = people.FirstOrDefault(p => p.Id == person.Id);
            if (personToUpdate != null)
            {
                personToUpdate.FirstName = person.FirstName;
                personToUpdate.LastName = person.LastName;
                personToUpdate.DateOfBirth = person.DateOfBirth; 
                personToUpdate.City = person.City;
                personToUpdate.StreetHouse = person.StreetHouse;
                personToUpdate.Cardnum = person.Cardnum;
                personToUpdate.Problem = person.Problem;
                personToUpdate.Diagnose = person.Diagnose;



                PersonRepository.StorePeople(people);
                return Ok();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var people = PersonRepository.GetPeople().ToList();

            var personToDelete = people.FirstOrDefault(p => p.Id == id);
            if (personToDelete != null)
            {
                people.Remove(personToDelete);

                PersonRepository.StorePeople(people);
                return Ok();
            }

            return NotFound();
        }

        private long GetNewId(IEnumerable<Person> people)
        {
            long newId = 0;
            foreach (var person in people)
            {
                if (newId < person.Id)
                {
                    newId = person.Id;
                }
            }

            return newId + 1;
        }
    }
}
