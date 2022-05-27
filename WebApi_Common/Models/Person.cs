using System;

namespace WebApi_Common.Models
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string StreetHouse { get; set; }
        public string Cardnum { get; set; }
        public string Problem { get; set; }
        public string Diagnose { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {DateOfBirth.Date} - {City} - {StreetHouse} - {Cardnum} - {Problem} - {Diagnose}";
        }
    }
}
