﻿// <auto-generated />
using System;
using LibraryEF_Context.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryEF_Context.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryEF_Context.Entitys.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Author")
                        .HasColumnType("int");

                    b.Property<int>("Id_Category")
                        .HasColumnType("int");

                    b.Property<int>("Id_Press")
                        .HasColumnType("int");

                    b.Property<int>("Id_Theme")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("YearPress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Author");

                    b.HasIndex("Id_Category");

                    b.HasIndex("Id_Press");

                    b.HasIndex("Id_Theme");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_Faculty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Faculty");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Lib", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libs");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Press", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Press");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.S_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOut")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Book")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Student")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Book");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Student");

                    b.ToTable("S_Card");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Group")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Term")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Group");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.T_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOut")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Book")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Teacher")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Book");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Teacher");

                    b.ToTable("T_Card");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Dep")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Dep");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Book", b =>
                {
                    b.HasOne("LibraryEF_Context.Entitys.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("Id_Author")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryEF_Context.Entitys.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("Id_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryEF_Context.Entitys.Press", "Press")
                        .WithMany("Books")
                        .HasForeignKey("Id_Press")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryEF_Context.Entitys.Theme", "Theme")
                        .WithMany("Books")
                        .HasForeignKey("Id_Theme")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Press");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Group", b =>
                {
                    b.HasOne("LibraryEF_Context.Entitys.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("Id_Faculty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.S_Card", b =>
                {
                    b.HasOne("LibraryEF_Context.Entitys.Book", "Book")
                        .WithMany("S_Cards")
                        .HasForeignKey("Id_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryEF_Context.Entitys.Lib", "Lib")
                        .WithMany("S_Cards")
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryEF_Context.Entitys.Student", "Student")
                        .WithMany("S_Cards")
                        .HasForeignKey("Id_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Student", b =>
                {
                    b.HasOne("LibraryEF_Context.Entitys.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("Id_Group")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.T_Card", b =>
                {
                    b.HasOne("LibraryEF_Context.Entitys.Book", "Book")
                        .WithMany("T_Cards")
                        .HasForeignKey("Id_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryEF_Context.Entitys.Lib", "Lib")
                        .WithMany("T_Cards")
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryEF_Context.Entitys.Teacher", "Teacher")
                        .WithMany("T_Cards")
                        .HasForeignKey("Id_Teacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Teacher", b =>
                {
                    b.HasOne("LibraryEF_Context.Entitys.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("Id_Dep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Book", b =>
                {
                    b.Navigation("S_Cards");

                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Department", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Faculty", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Lib", b =>
                {
                    b.Navigation("S_Cards");

                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Press", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Student", b =>
                {
                    b.Navigation("S_Cards");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Teacher", b =>
                {
                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("LibraryEF_Context.Entitys.Theme", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
