using ASP_DOT_NET_MVC_CRUD_APPLICATION.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASP_DOT_NET_MVC_CRUD_APPLICATION.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

    }
} 
