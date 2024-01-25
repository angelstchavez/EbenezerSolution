using System;

namespace EbenezerSolution.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string NumberPhone { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; } 
        public DateTime CreationDate { get; set; }
    }
}
