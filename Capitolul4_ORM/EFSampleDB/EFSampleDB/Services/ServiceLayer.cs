using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSampleDB.DomainModel;

namespace EFSampleDB
{
    class ServiceLayer
    {
        public bool AddStudent(Student student)
        {
            //validate student

            try
            {
                DataAccesLayer.DALServices dServices = new DataAccesLayer.DALServices();
                dServices.AddStudent(student);
                return true;
            }
            catch (Exception ex)
            {
                //log error
                return false;
            }
        }
        public List<Student> getStudentData()
        {
            DataAccesLayer.DALServices dServices = new DataAccesLayer.DALServices();

            var someStudents = dServices.GetStudentsWithTheirCourses();

            return someStudents;
            
            
        }
    }
}
