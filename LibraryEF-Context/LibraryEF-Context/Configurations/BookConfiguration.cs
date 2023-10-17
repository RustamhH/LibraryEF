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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.Pages).IsRequired();
            builder.Property(b => b.Quantity).IsRequired();
            builder.Property(b => b.Comment).IsRequired(false);
            builder.Property(b => b.YearPress).IsRequired();


            builder.HasOne(b => b.Category).WithMany(b => b.Books).HasForeignKey(b => b.Id_Category);
            builder.HasOne(b => b.Author).WithMany(b => b.Books).HasForeignKey(b => b.Id_Author);
            builder.HasOne(b => b.Press).WithMany(b => b.Books).HasForeignKey(b => b.Id_Press);
            builder.HasOne(b => b.Theme).WithMany(b => b.Books).HasForeignKey(b => b.Id_Theme);
            builder.HasMany(b => b.S_Cards).WithOne(b => b.Book).HasForeignKey(b => b.Id_Book);
            builder.HasMany(b => b.T_Cards).WithOne(b => b.Book).HasForeignKey(b => b.Id_Book);
        }
    }
}
