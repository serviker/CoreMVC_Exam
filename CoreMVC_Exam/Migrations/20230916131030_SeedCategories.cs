using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
SET IDENTITY_INSERT [dbo].[MyCategory] ON
INSERT INTO [dbo].[MyCategory] ([id], [nameCategory]) VALUES (1, N'Microwave')
INSERT INTO [dbo].[MyCategory] ([id], [nameCategory]) VALUES (2, N'Coffee machine')
INSERT INTO [dbo].[MyCategory] ([id], [nameCategory]) VALUES (3, N'Meat grinder')
INSERT INTO [dbo].[MyCategory] ([id], [nameCategory]) VALUES (4, N'Multicooker')
INSERT INTO [dbo].[MyCategory] ([id], [nameCategory]) VALUES (5, N'Juicer')
INSERT INTO [dbo].[MyCategory] ([id], [nameCategory]) VALUES (6, N'Air fryers')
SET IDENTITY_INSERT [dbo].[MyCategory] OFF
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
