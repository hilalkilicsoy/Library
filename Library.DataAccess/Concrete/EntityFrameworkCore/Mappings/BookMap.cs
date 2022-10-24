using Library.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataAccess.Concrete.EntityFrameworkCore.Mappings
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable(@"tblBooks", @"dbo");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).HasColumnName("Name");
            builder.Property(d => d.CategoryId).HasColumnName("CategoryId");
            builder.Property(d => d.Author).HasColumnName("Author");
            builder.Property(d => d.Pages).HasColumnName("Pages");
            builder.Property(d => d.IsActive).HasColumnName("IsActive");


        }
    }
}
