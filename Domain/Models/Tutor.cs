using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class Tutor : User
    {
        public int TutorId { get; set; }
        public string Description { get; set; }
        public int Raiting { get; set; }
        public EStatus Status { get; set; }
        public int PricePerHour { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
