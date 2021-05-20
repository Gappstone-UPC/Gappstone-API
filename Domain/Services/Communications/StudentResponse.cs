using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Gappstone.API.Domain.Models;

namespace Gappstone.API.Domain.Services.Communications
{
    public class StudentResponse : BaseResponse<Student>
    {
        public StudentResponse(Student resource) : base(resource)
        {
        }

        public StudentResponse(string message) : base(message)
        {
        }
    }
}
