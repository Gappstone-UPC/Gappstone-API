using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class Career
    {
        public int CareerId { get; set; }
        public string CarrerName { get; set; }
        public List<User> Users { get; set; }
        public List<UserCareer> UserCareers { get; set; }
    }
}
