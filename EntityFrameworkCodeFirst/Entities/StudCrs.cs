﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Entities
{
    public class StudCrs
    {
        public Student Student { get; set; }
        public int StudentId { get; set; }

        public Course Course { get; set; }
        
        public int CourseId { get; set; }

        public int? Grade { get; set; }

    }
}
