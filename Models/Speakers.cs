using System;

namespace SacramentMeetingPlanner.Models
{
    public class Speakers
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public string Subject { get; set; }
        
        public int PlanId { get; set; }
        public Plan Plan {get; set; }
        
        
    }
}
