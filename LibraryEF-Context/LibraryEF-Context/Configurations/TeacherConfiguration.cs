using LibraryEF_Context.Entitys;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasKey(b => b.Id);
            builder.Property(b => b.FirstName).IsRequired();
            builder.Property(b => b.LastName).IsRequired();


            builder.HasOne(b => b.Department).WithMany(b => b.Teachers).HasForeignKey(b => b.Id_Dep);
            builder.HasMany(b => b.T_Cards).WithOne(b => b.Teacher).HasForeignKey(b => b.Id_Teacher);

        }
    }
}
