using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS_Course_Work_3kurs.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBS_Course_Work_3kurs.EF
{
    public class LibraryDBContext : DbContext
    {
        public DbSet<Book> books { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Discount> discounts { get; set; }
        public DbSet<Fine> fines { get; set; }
        public DbSet<Lending> lendings { get; set; }

        public LibraryDBContext(DbContextOptions options)
            : base (options)
        {
        }

    }
}
