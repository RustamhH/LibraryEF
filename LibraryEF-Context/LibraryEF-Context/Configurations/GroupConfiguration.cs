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
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired();

            builder.HasOne(b => b.Faculty).WithMany(b => b.Groups).HasForeignKey(b => b.Id_Faculty);
            builder.HasMany(b => b.Students).WithOne(b => b.Group).HasForeignKey(b => b.Id_Group);
        }
    }
}
