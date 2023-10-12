using LibraryEF_Context.Configurations;
using LibraryEF_Context.Entitys;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Contexts
{
    public class LibraryDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = HOMEPC\\SQLEXPRESS;Database=Library;Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new FacultyConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new LibConfiguration());
            modelBuilder.ApplyConfiguration(new PressConfiguration());
            modelBuilder.ApplyConfiguration(new S_CardConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new T_CardConfiguration());
            modelBuilder.ApplyConfiguration(new ThemeConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lib> Libs { get; set; }
        public DbSet<Press> Press { get; set; }
        public DbSet<S_Card> S_Cards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<S_Card> T_Cards { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Theme> Themes { get; set; }


    }
}
