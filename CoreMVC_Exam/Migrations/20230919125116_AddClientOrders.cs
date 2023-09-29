using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class AddClientOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyClientOrder",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productBrand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    productModel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    startDate = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    endDate = table.Column<string>(type: "nvarchar(30)", maxLength: 40, nullable: false),
                    price = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyClientOrder", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyClientOrder");
        }
    }
}
