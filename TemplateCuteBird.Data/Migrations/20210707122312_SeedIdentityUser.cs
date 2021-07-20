using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemplateCuteBird.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("1f66c1e2-11b5-44c1-b371-967b700f3395"), "2a01eafb-e7c6-4d7b-9765-d0c3df94609b", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("834ed512-9d91-43aa-8c12-c7b2f11e5d5d"), new Guid("1f66c1e2-11b5-44c1-b371-967b700f3395") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("834ed512-9d91-43aa-8c12-c7b2f11e5d5d"), 0, "5799b158-04de-45cd-b8e2-8dec05f57840", "lcquang116@gmail.com", true, "Quang", "Le Chi", false, null, "lcquang116@gmail.com", "admin", "AQAAAAEAACcQAAAAEIt0t1Tnc5rMz9euF2jw+az0G7hIMdqlsPKDHy7oaJ2OA4N6SibU50pg0CJ28YE3jg==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f66c1e2-11b5-44c1-b371-967b700f3395"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("834ed512-9d91-43aa-8c12-c7b2f11e5d5d"), new Guid("1f66c1e2-11b5-44c1-b371-967b700f3395") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("834ed512-9d91-43aa-8c12-c7b2f11e5d5d"));
        }
    }
}
