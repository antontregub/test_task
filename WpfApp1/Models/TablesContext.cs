using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp1.Models
{
    class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnection")
        {

        }
        public DbSet<Student> Students { get; set; }

    }

    class GradeContext : DbContext
    {
        public GradeContext() : base("DefaultConnection")
        {

        }

        public DbSet<Grade> Grades { get; set; }
    }

}
