using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLayer.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NSE9T2O\\SQLEXPRESS01;database=CoreBlogApiDb;integrated security=true; ");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
