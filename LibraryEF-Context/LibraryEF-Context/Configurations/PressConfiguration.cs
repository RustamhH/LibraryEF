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
    public class PressConfiguration : IEntityTypeConfiguration<Press>
    {
        public void Configure(EntityTypeBuilder<Press> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired();

            builder.HasMany(b => b.Books).WithOne(b => b.Press).HasForeignKey(b => b.Id_Press);
        }
    }
}
