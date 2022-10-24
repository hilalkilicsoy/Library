using Library.DataAccess.Concrete.EntityFrameworkCore.Mappings;
using Library.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataAccess.Concrete.EntityFrameworkCore
{
    public class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source= DESKTOP-GEJQ3JC;Database=Library; integrated Security=true; Connection Timeout=1800; MultipleActiveResultSets=true; ");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryMap());
            modelBuilder.ApplyConfiguration<Book>(new BookMap());
        }
    }
}
