using Linq_Task1.data;
using Linq_Task1.Models;

namespace Linq_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDBContext context = new ApplicationDBContext();

            /* Add */

            Student student = new Student()
            {
                FirstName = "Nour",
                LastName = "Abdellatif",
                Age = 28,
                GPA = 10
            };

            context.Students.Add(student);
            context.SaveChanges();


            /* Add List */

            List<Student> students_add = new List<Student>()
            {
                new Student()
                {
                    FirstName="Hadeel",
                    LastName="Abdellatif",
                    Age=22,
                    GPA=5
                },

                   new Student()
                {
                    FirstName="Hanaa",
                    LastName="Abdellatif",
                    Age=12,
                    GPA=1
                }

            };

            context.AddRange(students_add);
            context.SaveChanges();


            /* Read */

            var students = context.Students.ToList();
            foreach(var item in students)
            {
                Console.WriteLine(item.FirstName);
            }


            /* Update */

            var student2 =context.Students.First(student => student.Id == 6);
            student2.FirstName = "Sara";
            context.SaveChanges();


            /* Delete */
            context.Students.Remove(student2);
            context.SaveChanges();


        }
    }
}
