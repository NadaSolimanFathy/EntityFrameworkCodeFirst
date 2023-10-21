using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCCAndTPH.Entities
{
    public abstract class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int Age { get; set; }
    }

    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee() : base()
        {

        }
        public DateTime StartDate { get; set; }
        public int Salary { get; set; }
    }



    internal class PartTimeEmployee : Employee
    {
        public PartTimeEmployee() : base()
        {

        }

        public double HourRate { get; set; }
        public int CountOfHours { get; set; }
    }
}
