using Library.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataAccess.Concrete.EntityFrameworkCore.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(@"tblCategories", @"dbo");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).HasColumnName("Name");
            builder.Property(d => d.IsActive).HasColumnName("IsActive");
          
        }
    }

}