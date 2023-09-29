using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class AddProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyProduct",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCategory = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    serialNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    releaseDate = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    modelName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProduct", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyProduct");
        }
    }
}
