using LibraryProject.MvcWebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryProject.MvcWebUI.Models.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=LibraryDb;User Id=sa;Password=1234;";
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Log> Logs { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasRequired<Category>(b => b.Category).WithMany(c => c.Books).HasForeignKey(b => b.CategoryId);
        }
    }
}