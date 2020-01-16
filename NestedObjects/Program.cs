using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.FullName = "travis";
            s.FullName = s.FullName.ToUpper();

            Course cpw212 = new Course()
            {
                CourseID = 1,
                CourseTitle = "Adv .NET",
                Credits = 5,
                Description = "Advanced C#"
            };

            s.Schedule.Add(cpw212);

            List<Course> courses = s.Schedule;
            courses.Add(cpw212);
            courses.Add(cpw212);
        }
    }
}
