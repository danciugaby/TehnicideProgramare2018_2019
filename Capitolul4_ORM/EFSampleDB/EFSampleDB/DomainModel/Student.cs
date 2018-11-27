using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleDB.DomainModel
{
    public class Student : Person
    {
        private List<Course> courses = new List<Course>();

        /// <summary>
        /// Gets or sets the speciality.
        /// </summary>
        /// <value>
        /// The speciality.
        /// </value>
        public String Speciality//e.g. Comp Sci
        {
            get;
            set;
        }
        public String A
        {
            get;set;
        }
        /// <summary>
        /// Gets or sets the enrolment date.
        /// </summary>
        /// <value>
        /// The enrolment date.
        /// </value>
        public DateTime EnrolmentDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Age
        {
            get;
            set;
        }

        /// <summary>
        /// Enrolls the in course.
        /// </summary>
        /// <param name="courseToEnrollInto">The course to enroll into.</param>
        public void EnrollInCourse(Course courseToEnrollInto)
        {
            if (courseToEnrollInto != null)//&& !courses.Contains(courseToEnrollInto)
            {
                Courses.Add(courseToEnrollInto);
            }
        }

        /// <summary>
        /// Gets the courses.
        /// </summary>
        /// <value>
        /// The courses.
        /// </value>
        

        public List<Course> Courses { get => courses; set => courses = value; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            String addressingAndFullName = Gender.ToString() + " " + FirstName + " " + LastName;
            String enrolment = "Enrolled at " + EnrolmentDate.ToShortDateString();
            String aged = "Aged " + Age.ToString();
            return addressingAndFullName + Environment.NewLine + enrolment + Environment.NewLine + aged;
        }
    }
}
