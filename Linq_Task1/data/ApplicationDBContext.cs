using Linq_Task1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Task1.data
{
    internal class ApplicationDBContext : DbContext
    {
        
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=students;trusted_connection=true;TrustServerCertificate=True");
        }
    }
}
