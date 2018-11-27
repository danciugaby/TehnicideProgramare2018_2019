using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleDB.DomainModel
{
    public class Course
    {
        private List<Student> enrolledStudents = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();

        #region Properties
        
        [Index(IsUnique = true)]        
        public int ID
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        /// <value>
        /// The name of the course.
        /// </value>
        public String CourseName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public String Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the enrolled students.
        /// </summary>
        /// <value>
        /// The enrolled students.
        /// </value>
        public virtual ICollection<Student> EnrolledStudents
        {
            get
            {
                return enrolledStudents.AsReadOnly();//why readonly?
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the given student to the current course.
        /// </summary>
        /// <param name="student">The student.</param>
        public void AddStudent(Student student)
        {
            if (student != null)
            {
                enrolledStudents.Add(student);
            }
        }

        /// <summary>
        /// Adds the given teacher to teh current course.
        /// </summary>
        /// <param name="teacher">The teacher.</param>
        public void AddTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                teachers.Add(teacher);
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Course name: " + CourseName + "; description: " + Description + "; enrolled students#: " + enrolledStudents.Count.ToString() + "; teachers#: " + teachers.Count.ToString();
        }

        #endregion
    }
}
