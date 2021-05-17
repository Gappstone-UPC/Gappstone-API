using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gappstone.API.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        public EUserType EUserType { get; set; }
        public string Name { get; set; }
        public int TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<UserCareer> UserCareers { get; set; }

    }
}
