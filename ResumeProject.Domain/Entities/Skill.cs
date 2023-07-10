﻿using ResumeProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeProject.Domain.Entities
{
    public class Skill:BaseEntity
    {
        public string Name { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
    }
}