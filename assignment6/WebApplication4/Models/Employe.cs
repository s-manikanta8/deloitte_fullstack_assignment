using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class Employe
    {
        public int EmployeId { get; set; }
        public string EmployeName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
    }
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
    }
    public class EmployeDbContext : DbContext
    {
        public DbSet<Employe> Employes { get; set; }
        public DbSet<User> Users { get; set; }

        public EmployeDbContext(DbContextOptions<EmployeDbContext> options)
         : base(options)
        {

        }
    }
}
