using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSampleDB.DomainModel;

namespace EFSampleDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student()
            {
                FirstName = "Andrei",
                LastName = "George",
                Speciality = "MATHS",
                EnrolmentDate = DateTime.Now
            };
            ServiceLayer services = new ServiceLayer();
            
            bool result1 = services.AddStudent(s);

            var someStudents =  services.getStudentData();
            foreach (var person in someStudents)
            {
                Console.WriteLine("Name: {0}, Courses: {1}",
                    person.FirstName,
                    String.Join(";", from c in person.Courses select c.CourseName)
                    );
            }

        }
    }
}
