using System;

namespace EbenezerSolution.Entity
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Day { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
