using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public string UniversityName { get; set; }
        public string Description { get; set; }
        //public List<User> Users { get; set; }
        public List<UserCareer> UserCareers { get; set; }

    }
}
