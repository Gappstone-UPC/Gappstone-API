using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class UserCareer
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int UniversityId { get; set; }
        public University University { get; set; }
        public string UniversityStudentCode { get; set; }

    }
}
