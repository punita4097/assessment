using BlazorAssignment1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment1.Data
{
    public class BlazorDbContext:DbContext

    {

        public BlazorDbContext(DbContextOptions<BlazorDbContext> options) : base(options)
        {

        }
        public DbSet<StudentInfo> Students { get; set; }
        public DbSet<LoginInfo> Logins { get; set; }

        public DbSet<NavBarInfo>NavBar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=BlazorDB;Trusted_Connection=True;");
        }
    }
}
