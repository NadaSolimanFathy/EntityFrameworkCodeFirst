using EntityFrameworkCodeFirst.DBContext;
using EntityFrameworkCodeFirst.Entities;
using System.ComponentModel;

namespace EntityFrameworkCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (DbContextNada context = new DbContextNada())
            {
                #region Adding Data

                #region Add Departments
                //Department department1 = new Department()
                //{
                //    Name = "CS",
                //};
                //Department department2 = new Department()
                //{
                //    Name = "IS",
                //};
                //Department department3 = new Department()
                //{
                //    Name = "MI",
                //};
                //Department department4 = new Department()
                //{
                //    Name = "ML",
                //};
                //context.Departments.Add(department1);
                //context.Departments.Add(department2);
                //context.Departments.Add(department3);
                //context.Departments.Add(department4);

                // context.SaveChanges();

                #endregion

                #region Add Instructor


                //Instructor inst1 = new Instructor()
                //{
                //    Name = "Ahmed khaled",
                //    Salary = 20000,
                //    Address = "Maadi",
                //    Bonus = 12,
                //    HourRate = 10,
                //    DepartmentId = 9
                //};

                //context.Instructors.Add(inst1); 
                #endregion


                #region Add Topic
                //Topic topic1 = new Topic()
                //{
                //    Name = "Computer Science"
                //};
                //Topic topic2 = new Topic()
                //{
                //    Name = "Software Engineering"
                //};
                //Topic topic3 = new Topic()
                //{
                //    Name = "Artificial intelligence"
                //};
                //Topic topic4 = new Topic()
                //{
                //    Name = "Machine Learning"
                //};
                //context.Topics.Add(topic1);
                //context.Topics.Add(topic2);
                //context.Topics.Add(topic3);
                //context.Topics.Add(topic4);
                //context.SaveChanges(); 
                #endregion

                #region Add Course

                //Course course1 = new Course()
                //{
                //    Name = "intro to CS",
                //    Duration = new DateTime(),
                //    Description = "this is the first course to introduce the computer science fields",
                //    TopicId = 1,
                //};
                //Course course2 = new Course()
                //{
                //    Name = "SW1",
                //    Duration = new DateTime(),
                //    Description = "this is the first course to introduce Software engineering",
                //    TopicId = 2

                //};
                //Course course3 = new Course()
                //{
                //    Name = "SW2",
                //    Duration = new DateTime(),
                //    Description = "this is the last course to teach Software engineering",
                //    TopicId = 2

                //};
                //context.Courses.Add(course1);
                //context.Courses.Add(course2);
                //context.Courses.Add(course3);

                //context.SaveChanges();
                #endregion

                #region Add Students

                //Student student1 = new Student()
                //{
                //    Fname = "Nada",
                //    Lname="Soliman",
                //    Age=22,
                //    Address="6October",
                //    DepartmentId=10,

                //};
                //Student student2 = new Student()
                //{
                //    Fname = "rasha",
                //    Lname = "omar",
                //    Age = 22,
                //    Address = "giza",
                //    DepartmentId = 10,
                //};

                //Student student3 = new Student()
                //{
                //    Fname = "yomna",
                //    Lname = "mohammed",
                //    Age = 22,
                //    Address = "Alex",
                //    DepartmentId = 10,

                //};
                //Student student4 = new Student()
                //{
                //    Fname = "fatma",
                //    Lname = "gamal",
                //    Age = 22,
                //    Address = "shubra",
                //    DepartmentId = 10,

                //};
                //Student student5 = new Student()
                //{
                //    Fname = "radwa",
                //    Lname = "ayman",
                //    Age = 22,
                //    Address = "shubra",
                //    DepartmentId = 10,

                //};
                //Student student6 = new Student()
                //{
                //    Fname = "hager",
                //    Lname = "shabaan",
                //    Age = 22,
                //    Address = "qalyub",
                //    DepartmentId = 10,

                //};
                //context.Students.Add(student1);
                //context.Students.Add(student2);
                //context.Students.Add(student3);
                //context.Students.Add(student4);
                //context.Students.Add(student5);
                //context.Students.Add(student6);

                //Student student7 = new Student()
                //{
                //    Fname = "rana",
                //    Lname = "ahmed",
                //    Age = 18,
                //    Address = "Daqahlia",
                //    DepartmentId = 8,

                //};

                //Student student8 = new Student()
                //{
                //    Fname = "ahmed",
                //    Lname = "ehab",
                //    Age = 18,
                //    Address = "obour",
                //    DepartmentId = 8,

                //};
                //context.Students.Add(student7);
                //context.Students.Add(student8);

                // context.SaveChanges();

                #endregion


                #region Assign Students To Courses
                //StudCrs studCrs1 = new StudCrs()
                //{
                //    CourseId = 2,
                //    StudentId=7
                //};
                //StudCrs studCrs2 = new StudCrs()
                //{
                //    CourseId = 2,
                //    StudentId = 8
                //};
                //StudCrs studCrs3 = new StudCrs()
                //{
                //    CourseId = 3,
                //    StudentId = 1
                //};
                //StudCrs studCrs4 = new StudCrs()
                //{
                //    CourseId = 3,
                //    StudentId = 2
                //};
                //StudCrs studCrs5 = new StudCrs()
                //{
                //    CourseId = 3,
                //    StudentId = 4
                //};
                //StudCrs studCrs6 = new StudCrs()
                //{
                //    CourseId = 3,
                //    StudentId = 5
                //};
                //context.StudCrses.Add(studCrs1);
                //context.StudCrses.Add(studCrs2);
                //context.StudCrses.Add(studCrs3);
                //context.StudCrses.Add(studCrs4);
                //context.StudCrses.Add(studCrs5);
                //context.StudCrses.Add(studCrs6);
                //context.SaveChanges();
                #endregion

                #endregion


                #region Retreive some data


                //select all data
                Console.WriteLine("---------------------All Students-------------------- ");

                var students =context.Students.ToList();
                foreach (var student in students)
                {
                    Console.WriteLine(student.Fname +" "+ student.Lname);
                }
                Console.WriteLine("-----------------Students that regiser sw1 course------------------------ ");


                var sw1Students = from student in context.Students
                                  join stuCrs in context.StudCrses
                                  on student.Id equals stuCrs.StudentId
                                  where stuCrs.CourseId == 3
                                 select new
                                 {
                                     student.Fname,
                                     student.Lname,
                                 };

                foreach (var student in sw1Students)
                {
                    Console.WriteLine(student.Fname + " " + student.Lname);
                }


                Console.WriteLine("-----------------Students that regiser intro to CS course------------------------ ");


                var introToCsStudents = from student in context.Students
                                  join stuCrs in context.StudCrses
                                  on student.Id equals stuCrs.StudentId
                                  where stuCrs.CourseId == 2
                                  select new
                                  {
                                      student.Fname,
                                      student.Lname,
                                  };

                foreach (var student in introToCsStudents)
                {
                    Console.WriteLine(student.Fname + " " + student.Lname);
                }
                #endregion

            }


        }
    }
}