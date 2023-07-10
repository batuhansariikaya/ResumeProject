using ResumeProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeProject.Domain.Entities
{
    public class Project:BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string GithubLink { get; set; }
    }
}
