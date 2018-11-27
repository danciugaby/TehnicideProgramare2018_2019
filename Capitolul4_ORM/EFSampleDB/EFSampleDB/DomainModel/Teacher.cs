using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleDB.DomainModel
{
    public class Teacher : Person
    {
        private List<Course> courses = new List<Course>();

        /// <summary>
        /// Gets or sets the domains of interest.
        /// </summary>
        /// <value>
        /// The domains of interest.
        /// </value>
        public List<String> DomainsOfInterest
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the taught courses.
        /// </summary>
        /// <value>
        /// The taught courses.
        /// </value>
        public ICollection<Course> TaughtCourses
        {
            get
            {
                return courses.AsReadOnly();
            }
        }

        /// <summary>
        /// Adds as teacher to course.
        /// </summary>
        /// <param name="course">The course.</param>
        public void AddAsTeacherToCourse(Course course)
        {
            if (course != null)//exercitiu: cum se evita adaugarea in mod repetat a unui curs in lista?
            {
                courses.Add(course);
            }
        }
        public String Phone { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string addressingAndName = "Prof. " + FirstName + " " + LastName;
            string domains = String.Join(", ", DomainsOfInterest);
            return addressingAndName + Environment.NewLine + domains;
        }
    }
}
