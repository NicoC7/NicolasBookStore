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

        public static implicit operator ApplicationException(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        } // Fix an error
    }
}
