using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class AddOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyOrder",
                columns: table => new
                {
                    id = table.Column<int>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduct = table.Column<int>(type: "varchar(30)", maxLength: 30, nullable: false),
                    idClient = table.Column<int>(type: "varchar(30)", maxLength: 30, nullable: false),
                    startDate = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    endDate = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    price = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyOrder", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyOrder");
        }
    }
}
