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
    public class SkillReadRepository : ReadRepository<Skill>, ISkillReadRepository
    {
        public SkillReadRepository(ResumeProjectDbContext context) : base(context)
        {
        }
    }
}
