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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.FirstName).IsRequired();
            builder.Property(b => b.LastName).IsRequired();
            builder.Property(b => b.Term).IsRequired();


            builder.HasOne(b => b.Group).WithMany(b => b.Students).HasForeignKey(b => b.Id_Group);
            builder.HasMany(b => b.S_Cards).WithOne(b => b.Student).HasForeignKey(b => b.Id_Student);

        }
    }
}
