using System;

namespace EbenezerSolution.Entity
{
    public class MinistryMember
    {
        public int Id { get; set; }
        public Ministry Ministry { get; set; }
        public Person Member { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
