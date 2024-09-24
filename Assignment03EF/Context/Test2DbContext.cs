using Assignment03EF.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03EF.Context
{
    internal class Test2DbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = Company ; Trusted_Connection = true");
        }
        //public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullTimeEmployee>()
                        .HasBaseType<Employee>();

            modelBuilder.Entity<PartTimeEmployee>()
                        .HasBaseType<Employee>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
