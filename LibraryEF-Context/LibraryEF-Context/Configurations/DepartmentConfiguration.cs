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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name).IsRequired();

            builder.HasMany(b => b.Teachers).WithOne(b => b.Department).HasForeignKey(b => b.Id_Dep);
        }
    }
}
