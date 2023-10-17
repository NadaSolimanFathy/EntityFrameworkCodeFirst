using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Entities
{
    public class CourseInst
    {
        public Instructor Instructor { get; set; }
        public int InstructorId { get; set; }

        public Course Course { get; set; }

        public int CourseId { get; set; }

        public int Evaluate { get; set; }
    }
}
