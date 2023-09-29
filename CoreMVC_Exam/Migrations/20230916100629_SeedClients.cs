using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class SeedClients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
SET IDENTITY_INSERT [dbo].[MyClient] ON
INSERT INTO [dbo].[MyClient] ([id], [idPassport], [firstName], [lastName], [address], [phone], [dateBirth]) VALUES (1, N'669988', N'Dmitriy', N'Serov', N'Lenina, 44', N'89872345786', N'1969-08-12 00:00:00')
INSERT INTO [dbo].[MyClient] ([id], [idPassport], [firstName], [lastName], [address], [phone], [dateBirth]) VALUES (2, N'339485', N'Anna', N'Krasina', N'Komunaknaya, 6', N'89737474789', N'2000-11-30 00:00:00')
INSERT INTO [dbo].[MyClient] ([id], [idPassport], [firstName], [lastName], [address], [phone], [dateBirth]) VALUES (3, N'438944', N'Roma', N'Dudkin', N'Shahterskaya, 34', N'89335434333', N'1986-05-18 00:00:00')
INSERT INTO [dbo].[MyClient] ([id], [idPassport], [firstName], [lastName], [address], [phone], [dateBirth]) VALUES (4, N'389756', N'Fedor', N'Melnikov', N'Artema, 242', N'89497823788', N'1981-11-19 00:00:00')
SET IDENTITY_INSERT [dbo].[MyClient] OFF

            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
