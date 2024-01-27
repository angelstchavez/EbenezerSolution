using System;

namespace EbenezerSolution.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool UserIsActive { get; set; }
        public Role Role { get; set; }
        public DateTime CreationDate { get; set; }
    }
}