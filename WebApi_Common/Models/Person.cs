using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi_Common.Models
{
    public class Person
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string StreetHouse { get; set; }
        [Required]
        public string Cardnum { get; set; }
        [Required]
        public string Problem { get; set; }
        [Required]
        public string Diagnose { get; set; }
        [Required]
        public DateTime AddedTime { get; set; }

       /* public override string ToString()
        {
            return $"{FirstName} {LastName} - {DateOfBirth.Date} - {City} - {StreetHouse} - {Cardnum} - {Problem} - {Diagnose} - {AddedTime}";
        }*/
    }
}
