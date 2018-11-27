using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSampleDB.DomainModel;

namespace EFSampleDB.DataAccesLayer
{
    class DALServices
    {
        public void AddStudent(Student student)
        {  
            using (var context = new DataBaseContext())
            {
                context.Students.Add(student);                
                context.SaveChanges();                
            }
        }

        public List<Student> GetStudentsWithTheirCourses()
        {

            using (var context = new DataBaseContext())
            {
                //assures join with other tables
                var people = context.Students;
                //force ToList to avoid LINQ to Entities deferred execution
                return people.ToList();
            }
        }
    }
}
