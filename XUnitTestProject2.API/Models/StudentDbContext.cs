using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XUnitTestProject2.API.Models
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
        public StudentDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DESKTOP-KK1QB16;Database=StuDb;Trusted_Connection=True");
            base.OnConfiguring(builder);
        }


    }
}
