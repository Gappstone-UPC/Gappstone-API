using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class Tutorship
    {
        public int TutorshipId { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public string Theme { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }
        public int CommissionId { get; set; }
        public Commission Commission { get; set; }
    }
}
