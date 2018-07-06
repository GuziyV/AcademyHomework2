using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyHomework2.Models
{
    public class Comment
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public int Likes { get; set; }

        public override string ToString()
        {
            return "COMMENT: Id: " + Id + ", Date: " + CreatedAt + ", Body: " + Body + ", UserId: " + UserId + 
                ", PostId: " + PostId + ", Likes: " + Likes;
        }
    }
}
