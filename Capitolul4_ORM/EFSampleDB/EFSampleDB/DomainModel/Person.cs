using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleDB.DomainModel
{
    public abstract class Person
    {
        public int ID
        {
            get;
            set;
        }

        public String FirstName
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        public String EmailAddress
        {
            get;
            set;
        }

        public GenderType Gender
        {
            get;
            set;
        }
    }
}
