using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class SeedOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
SET IDENTITY_INSERT [dbo].[MyOrder] ON'
INSERT INTO [dbo].[MyOrder] ([id], [IdProduct], [idClient], [startDate], [endDate], [price]) VALUES (1, N'1', 3, N'2023-09-10 00:00:00', N'2023-09-30 00:00:00', N'1200')
INSERT INTO [dbo].[MyOrder] ([id], [IdProduct], [idClient], [startDate], [endDate], [price]) VALUES (2, N'4', 2, N'2023-09-13 00:00:00', N'2023-09-25 00:00:00', N'500')
INSERT INTO [dbo].[MyOrder] ([id], [IdProduct], [idClient], [startDate], [endDate], [price]) VALUES (3, N'5', 1, N'2023-08-31 00:00:00', N'2023-09-30 00:00:00', N'2000')
INSERT INTO [dbo].[MyOrder] ([id], [IdProduct], [idClient], [startDate], [endDate], [price]) VALUES (4, N'12', 4, N'2023-09-15 00:00:00', N'2023-10-15 00:00:00', N'1600')
SET IDENTITY_INSERT [dbo].[MyOrder] OFF

            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
