﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentCategoryId { get; set; }

        public bool IsActive { get; set; }

    }
}
