using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pregunt2.Models
{
    public class DataContext : DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Pregunt2.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<Pregunt2.Models.Enrollment> Enrollments { get; set; }

        public System.Data.Entity.DbSet<Pregunt2.Models.Course> Courses { get; set; }
    }
}