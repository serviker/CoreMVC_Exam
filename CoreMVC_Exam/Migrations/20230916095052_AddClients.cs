using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class AddClients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyClient",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPassport = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    firstName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    lastName = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    address = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    phone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    dateBirth = table.Column<string>(type: "varchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyClient", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyClient");
        }
    }
}
