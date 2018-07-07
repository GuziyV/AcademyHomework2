using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyHomework2.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Avatar { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public List<Post> Posts { get; set; }
        [Required]
        public List<Todo> Todos { get; set; } 

        public void ShowTodos()
        {
            foreach(var todo in Todos)
            {
                Console.WriteLine("TODO: {0}", todo.Name);
            }
        }

        public override string ToString()
        {
            return  "USER: Id: " + Id + ", Date: " + CreatedAt + ", Name: " + Name + ", Avatar: " + Avatar + ", Email: " + Email;
        }
    }
}
