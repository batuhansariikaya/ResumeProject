using ResumeProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeProject.Domain.Entities
{
    public class Service:BaseEntity 
    {
        public string Name { get; set; }
        public string IconUrl { get; set; }
    }
}
