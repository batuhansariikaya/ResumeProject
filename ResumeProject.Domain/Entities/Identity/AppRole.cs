using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeProject.Domain.Entities.Identity
{
    public class AppRole:IdentityRole<Guid>
    {
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
