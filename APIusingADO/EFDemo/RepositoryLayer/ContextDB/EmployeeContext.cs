using CommonLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.ContextDB
{
    public class EmployeeContext : DbContext
    {
            public EmployeeContext(DbContextOptions options) : base(options)
            {

            }
            public DbSet<Employee> Employees { get; set; }
    }
}
