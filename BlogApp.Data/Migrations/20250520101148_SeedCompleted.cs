using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("2671c8b7-fd88-4a59-841e-817dd64a0f88"), "Admin Test", new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(1998), null, null, null, null, "Visual Studio 2022", false },
                    { new Guid("ef3bf98c-a244-4de1-a0ae-a713f671817e"), "Admin Test", new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(1984), null, null, null, null, "ASP.NET CORE", false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "ModifiedBy", "ModifiedDate", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("299a6cf4-5c0f-433c-9f9f-48a66e99cb70"), "Admin Test", new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(2899), null, null, "images/vstest", "jpg", null, null, false },
                    { new Guid("b1cdbffc-0b49-4b3b-81d8-2fd38b6dd533"), "Admin Test", new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(2896), null, null, "images/testimage", "jpg", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("4780def1-0ebf-42f2-85a4-fb91c764f8db"), new Guid("2671c8b7-fd88-4a59-841e-817dd64a0f88"), " Visual Studio Lorem İpsummmmm", "Admin Test", new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(772), null, null, new Guid("299a6cf4-5c0f-433c-9f9f-48a66e99cb70"), null, null, "Visual Studio Deneme Makalesi 1", 15, false },
                    { new Guid("e4f66ada-d6ff-40db-b52b-28a3b2736890"), new Guid("ef3bf98c-a244-4de1-a0ae-a713f671817e"), "Asp.Net Core Lorem İpsummmmm", "Admin Test", new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(767), null, null, new Guid("b1cdbffc-0b49-4b3b-81d8-2fd38b6dd533"), null, null, "Asp.Net Core Deneme Makalesi 1", 15, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4780def1-0ebf-42f2-85a4-fb91c764f8db"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e4f66ada-d6ff-40db-b52b-28a3b2736890"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2671c8b7-fd88-4a59-841e-817dd64a0f88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef3bf98c-a244-4de1-a0ae-a713f671817e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("299a6cf4-5c0f-433c-9f9f-48a66e99cb70"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b1cdbffc-0b49-4b3b-81d8-2fd38b6dd533"));
        }
    }
}
