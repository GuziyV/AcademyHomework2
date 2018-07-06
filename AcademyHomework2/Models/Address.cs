using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyHomework2.Models
{
    public class Address
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        public string UserId { get; set; }


        public override string ToString()
        {
            return Id + " " + CreatedAt + " " + Country + " " + City + " " + Zip + " " + UserId;
        }
    }
}
