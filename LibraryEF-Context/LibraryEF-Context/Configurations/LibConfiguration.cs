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
    public class LibConfiguration : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.FirstName).IsRequired();
            builder.Property(b => b.LastName).IsRequired();

            builder.HasMany(b => b.S_Cards).WithOne(b => b.Lib).HasForeignKey(b => b.Id_Lib);
            builder.HasMany(b => b.T_Cards).WithOne(b => b.Lib).HasForeignKey(b => b.Id_Lib);
        }
    }
}
