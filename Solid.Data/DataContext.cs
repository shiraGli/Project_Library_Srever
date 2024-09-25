using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data
{
    public class DataContext: DbContext
    { 
        public DbSet<Customer> customers { get; set; }
        public DbSet<Book> book { get; set; }
        public DbSet<Account> account { get; set; }
        public DbSet<Books_on_loan> books_on_loan { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Lend> lend { get; set; }
        public DbSet<Writer> writer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=shira_Library_db");
        }

    }

}
