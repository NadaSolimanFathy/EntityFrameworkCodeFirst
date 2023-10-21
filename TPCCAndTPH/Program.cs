using TPCCAndTPH.Context;
using TPCCAndTPH.Entities;

namespace TPCCAndTPH
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using(MyDbContext context=new MyDbContext())
            {

                FullTimeEmployee FullTimeEmp = new FullTimeEmployee()
                {
                    Name = "Nada",
                    Address="6October",
                    Age=23,
                    Salary=5000,
                    StartDate=DateTime.Now,
                };

                PartTimeEmployee PartTimeEmp = new PartTimeEmployee()
                {
                    Name = "Nada",
                    Address = "6October",
                    Age = 23,
                    HourRate = 12,
                    CountOfHours = 150
                };

                //i don't have  FullTimeEmployees in myDbContext , i just have Employees
                // i can use  context.Set<FullTimeEmployees>.Add
                // context.FullTimeEmployees.Add(FullTimeEmp);
                context.Employees.Add(FullTimeEmp);
                context.Employees.Add(PartTimeEmp);

                context.SaveChanges();

                foreach(var employee in context.Employees.OfType<FullTimeEmployee>())
                    Console.WriteLine($"{employee.Name } :: { employee.Salary}");


                foreach (var employee in context.Employees.OfType<PartTimeEmployee>())
                    Console.WriteLine($"{employee.Name } :: { employee.HourRate*employee.CountOfHours}");

            }


        }
    }
}