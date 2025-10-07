using Microsoft.EntityFrameworkCore;
using Company_Employee.Models;

namespace Company_Employee.Data
{
    public class EmpDbContext : DbContext
    {
        
          public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options) { }  
          public DbSet<Department> Departments { get; set; }
          public DbSet<Employees> Employees { get; set; }
          public DbSet<Users> Users { get; set; }
          public DbSet<Devices> Devices { get; set; }
          public DbSet<Maintenance> Maintenance { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employees>()
                .HasIndex(e => e.Emp_Phone)
                .IsUnique();

            //Configure relation oe to one  Dvice & Employee

            //modelBuilder.Entity<Devices>()
               
  
        }

    }
}
