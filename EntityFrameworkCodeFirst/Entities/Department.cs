using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? HireDate { get; set; } = DateTime.Now;


        public ICollection<Student> Students { get; set; }


        //[InverseProperty("DepartmentId")]

        public ICollection<Instructor> instructors { get; set; }

        [Column("managerId")]
        public int? InstructorId { get; set; }
        public Instructor instructor { get; set; }

    }
}
