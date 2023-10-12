using LibraryEF_Context.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.FirstName).IsRequired();
            builder.Property(b => b.LastName).IsRequired();

            builder.HasMany(b => b.Books).WithOne(b => b.Author).HasForeignKey(b => b.Id_Author);
        }
    }
}
