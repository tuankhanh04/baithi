using Microsoft.EntityFrameworkCore;

namespace Bai_thi_ASPcore.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() { }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
          : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=khuong\\SQLEXPRESS03;Initial Catalog=DBEmployee;User ID=sa;Password=25122004;Encrypt=False");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
