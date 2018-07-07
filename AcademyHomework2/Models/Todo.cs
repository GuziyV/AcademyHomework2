using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyHomework2.Models
{
    public class Todo
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsComplete { get; set; }
        [Required]
        public int UserId { get; set; }

        public override string ToString()
        {
            return "TODO: Id: " + Id + ", Date: " + CreatedAt + ", Name: " + Name + ", IsDone: " + IsComplete + ", " + UserId;
        }
    }
}
