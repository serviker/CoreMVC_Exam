using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
SET IDENTITY_INSERT [dbo].[MyProduct] ON
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (1, N'1', N'28726542', N'2020-12-20 00:00:00', N'11000', N'LG', N'MS-20R42D')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (2, N'1', N'34875393', N'2022-01-25 00:00:00', N'7200', N'BBK', N'20MWS-722T/B-M')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (3, N'2', N'33653442', N'2022-03-30 00:00:00', N'6990', N'Kitfort', N'КТ-7105-1')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (4, N'3', N'23729294', N'2022-09-10 00:00:00', N'3290', N'Econ ', N'ECO-1054MG')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (5, N'3', N'56363565', N'2023-07-10 00:00:00', N'6000', N'Polaris ', N'PMG 1854')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (6, N'4', N'09450423', N'2023-01-23 00:00:00', N'7700', N'REDMOND ', N'RMC-M90')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (8, N'4', N'30495303', N'2023-04-19 00:00:00', N'4590', N'Polaris ', N'PMC 0567AD')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (9, N'5', N'23454553', N'2020-03-10 00:00:00', N'8300', N'Polaris ', N'PEA 1535AL')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (11, N'5', N'34756399', N'2021-09-29 00:00:00', N'6500', N'Scarlett ', N'SC-JE50S40')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (12, N'6', N'43335635', N'2022-02-10 00:00:00', N'7000', N'Lydsto Air Fryer', N'5L XD-ZNKQZG03')
INSERT INTO [dbo].[MyProduct] ([id], [idCategory], [serialNumber], [releaseDate], [price], [Brand], [modelName]) VALUES (13, N'6', N'48973934', N'2021-09-22 00:00:00', N'5999', N'JVC', N'JK-MB050')
SET IDENTITY_INSERT [dbo].[MyProduct] OFF
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
