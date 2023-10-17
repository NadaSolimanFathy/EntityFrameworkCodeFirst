using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Duration { get; set; }
        public string Description { get; set; }
        public int TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
