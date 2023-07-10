using ResumeProject.Application.Repositories;
using ResumeProject.Domain.Entities;
using ResumeProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeProject.Persistence.Repositories
{
    public class ProjectWriteRepository : WriteRepository<Project>, IProjectWriteRepository
    {
        public ProjectWriteRepository(ResumeProjectDbContext context) : base(context)
        {
        }
    }
}
