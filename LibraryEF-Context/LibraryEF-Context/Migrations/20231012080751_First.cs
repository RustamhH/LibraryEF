using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryEF_Context.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Press",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Press", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Dep = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Departments_Id_Dep",
                        column: x => x.Id_Dep,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Faculty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Faculties_Id_Faculty",
                        column: x => x.Id_Faculty,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    YearPress = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Category = table.Column<int>(type: "int", nullable: false),
                    Id_Theme = table.Column<int>(type: "int", nullable: false),
                    Id_Author = table.Column<int>(type: "int", nullable: false),
                    Id_Press = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_Id_Author",
                        column: x => x.Id_Author,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_Id_Category",
                        column: x => x.Id_Category,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Press_Id_Press",
                        column: x => x.Id_Press,
                        principalTable: "Press",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Themes_Id_Theme",
                        column: x => x.Id_Theme,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Group = table.Column<int>(type: "int", nullable: false),
                    Term = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Groups_Id_Group",
                        column: x => x.Id_Group,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Teacher = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false),
                    Id_Lib = table.Column<int>(type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Card_Books_Id_Book",
                        column: x => x.Id_Book,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Card_Libs_Id_Lib",
                        column: x => x.Id_Lib,
                        principalTable: "Libs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Card_Teachers_Id_Teacher",
                        column: x => x.Id_Teacher,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "S_Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Student = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false),
                    Id_Lib = table.Column<int>(type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_S_Card_Books_Id_Book",
                        column: x => x.Id_Book,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_S_Card_Libs_Id_Lib",
                        column: x => x.Id_Lib,
                        principalTable: "Libs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_S_Card_Students_Id_Student",
                        column: x => x.Id_Student,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Author",
                table: "Books",
                column: "Id_Author");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Category",
                table: "Books",
                column: "Id_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Press",
                table: "Books",
                column: "Id_Press");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Theme",
                table: "Books",
                column: "Id_Theme");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Id_Faculty",
                table: "Groups",
                column: "Id_Faculty");

            migrationBuilder.CreateIndex(
                name: "IX_S_Card_Id_Book",
                table: "S_Card",
                column: "Id_Book");

            migrationBuilder.CreateIndex(
                name: "IX_S_Card_Id_Lib",
                table: "S_Card",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_S_Card_Id_Student",
                table: "S_Card",
                column: "Id_Student");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Id_Group",
                table: "Students",
                column: "Id_Group");

            migrationBuilder.CreateIndex(
                name: "IX_T_Card_Id_Book",
                table: "T_Card",
                column: "Id_Book");

            migrationBuilder.CreateIndex(
                name: "IX_T_Card_Id_Lib",
                table: "T_Card",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_T_Card_Id_Teacher",
                table: "T_Card",
                column: "Id_Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Id_Dep",
                table: "Teachers",
                column: "Id_Dep");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "S_Card");

            migrationBuilder.DropTable(
                name: "T_Card");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Libs");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Press");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
