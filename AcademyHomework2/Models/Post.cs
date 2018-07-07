using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyHomework2.Models
{
    public class Post
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } 

        public override string ToString()
        {
            return "POST: Id: " + Id + ", Date: " + CreatedAt + ", Title: " + Title + ", Body: " + Body +  ", UserId: "
                + UserId + ", Likes: " + Likes;
        }
    }
}
