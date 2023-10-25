using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lesson11
{
    public partial class UniversityDbContext : DbContext
    {
        public UniversityDbContext()
            : base("Data Source=DESKTOP-SQ15PPH;Initial Catalog=University;Integrated Security=True")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
