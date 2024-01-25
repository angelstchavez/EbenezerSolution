using System;

namespace EbenezerSolution.Entity
{
    public class ActivityParticipant
    {
        public int Id { get; set; }
        public Activity Activity { get; set; }
        public Person Participant { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
