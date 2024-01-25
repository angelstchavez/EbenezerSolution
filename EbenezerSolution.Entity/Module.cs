using System;

namespace EbenezerSolution.Entity
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Role Role { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
