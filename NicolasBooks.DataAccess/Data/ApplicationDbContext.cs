using NicolasBooks.Models; //add this using statement
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NicolasBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category>Categories { get; set; } // add this line
        public object CoverTypes { get; internal set; } // Addding covertypes to the database

        public DbSet<Product> Products { get; set; } // Addding products to the database
    }
}
