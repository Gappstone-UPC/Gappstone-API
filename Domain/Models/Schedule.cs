using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class Schedule
    {
        public int ScheludeId { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }

        public List<Tutorship> Tutorships { get; set; }
    }
}
