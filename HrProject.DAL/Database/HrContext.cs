using HrProject.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProject.DAL.Database
{
    public class HrContext : DbContext
    {
        public DbSet<CardsType> CardsType { get; set; }
        public DbSet<CommTools> CommTools { get; set; }
        public DbSet<Bank> Bank { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=HrDb;Integrated Security=true");
        }
    }
}
