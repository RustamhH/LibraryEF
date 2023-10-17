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
    public class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasKey(b => b.Id);
            builder.Property(b => b.DateIn).IsRequired(false);
            builder.Property(b => b.DateOut).IsRequired().HasDefaultValue(DateTime.Now);


            builder.HasOne(b => b.Book).WithMany(b => b.T_Cards).HasForeignKey(b => b.Id_Book);
            builder.HasOne(b => b.Lib).WithMany(b => b.T_Cards).HasForeignKey(b => b.Id_Lib);
            builder.HasOne(b => b.Teacher).WithMany(b => b.T_Cards).HasForeignKey(b => b.Id_Teacher);
        }
    }
}
