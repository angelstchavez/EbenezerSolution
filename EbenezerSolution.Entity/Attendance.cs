using System;

namespace EbenezerSolution.Entity
{
    internal class Attendance
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public Person Assistant { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
