using System;

namespace studentApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student();
                student.Name = "Mateo";

                context.students.Add(student);
                context.SaveChanges();
            }
        }
    }
}