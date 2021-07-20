using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemplateCuteBird.Data.Migrations
{
    public partial class HomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Url = table.Column<string>(maxLength: 200, nullable: false),
                    Image = table.Column<string>(maxLength: 200, nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f66c1e2-11b5-44c1-b371-967b700f3395"),
                column: "ConcurrencyStamp",
                value: "8e402ece-4ef8-44e6-8f87-f4276121ba47");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("834ed512-9d91-43aa-8c12-c7b2f11e5d5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10544f14-09b2-41b3-9384-7fe6f5206d62", "AQAAAAEAACcQAAAAEMarApJnT2ervK3ffjOuycUl2mvIEsxcBvLDNr1jht6megocNeLk/o8kAuaU2qEiQg==" });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "Description", "Image", "Name", "SortOrder", "Status", "Url" },
                values: new object[,]
                {
                    { 1, "Template Cute Bird", "./image/user/carousel1.jpg", "Second Thumbnail label", 1, 1, "#" },
                    { 2, "Template Cute Bird", "./image/user/carousel2.jpg", "Second Thumbnail label", 2, 1, "#" },
                    { 3, "Template Cute Bird", "./image/user/carousel3.jpg", "Second Thumbnail label", 3, 1, "#" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f66c1e2-11b5-44c1-b371-967b700f3395"),
                column: "ConcurrencyStamp",
                value: "2a01eafb-e7c6-4d7b-9765-d0c3df94609b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("834ed512-9d91-43aa-8c12-c7b2f11e5d5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5799b158-04de-45cd-b8e2-8dec05f57840", "AQAAAAEAACcQAAAAEIt0t1Tnc5rMz9euF2jw+az0G7hIMdqlsPKDHy7oaJ2OA4N6SibU50pg0CJ28YE3jg==" });
        }
    }
}
