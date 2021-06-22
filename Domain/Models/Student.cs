using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class Student : User
    {
        public int StudentId { get; set; }
        public User User { get; set; }

        public List<Tutorship> Tutorships { get; set; }
    }
}
