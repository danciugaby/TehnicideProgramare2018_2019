using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSampleDB.DomainModel;

namespace EFSampleDB.DataAccesLayer
{
    class DataBaseContext : DbContext
    {        
        public DbSet<Student> Students
        {
            get;
            set;
        }
        public DbSet<Teacher> Teachers
        {
            get;
            set;
        }
        public DbSet<Course> Courses
        {
            get;
            set;
        }
    }
}
