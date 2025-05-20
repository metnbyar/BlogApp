using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4780def1-0ebf-42f2-85a4-fb91c764f8db"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e4f66ada-d6ff-40db-b52b-28a3b2736890"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("14a9ef68-b2c0-4388-b0d5-01c7ce746b33"), new Guid("ef3bf98c-a244-4de1-a0ae-a713f671817e"), "Asp.Net Core Lorem İpsummmmm", "Admin Test", new DateTime(2025, 5, 20, 17, 45, 37, 947, DateTimeKind.Local).AddTicks(6340), null, null, new Guid("b1cdbffc-0b49-4b3b-81d8-2fd38b6dd533"), null, null, "Asp.Net Core Deneme Makalesi 1", 15, false },
                    { new Guid("2c2b0b17-9829-4272-afde-c0cf1e1c3566"), new Guid("2671c8b7-fd88-4a59-841e-817dd64a0f88"), " Visual Studio Lorem İpsummmmm", "Admin Test", new DateTime(2025, 5, 20, 17, 45, 37, 947, DateTimeKind.Local).AddTicks(6350), null, null, new Guid("299a6cf4-5c0f-433c-9f9f-48a66e99cb70"), null, null, "Visual Studio Deneme Makalesi 1", 15, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2671c8b7-fd88-4a59-841e-817dd64a0f88"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 17, 45, 37, 947, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef3bf98c-a244-4de1-a0ae-a713f671817e"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 17, 45, 37, 947, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("299a6cf4-5c0f-433c-9f9f-48a66e99cb70"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 17, 45, 37, 948, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b1cdbffc-0b49-4b3b-81d8-2fd38b6dd533"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 17, 45, 37, 948, DateTimeKind.Local).AddTicks(659));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("14a9ef68-b2c0-4388-b0d5-01c7ce746b33"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2c2b0b17-9829-4272-afde-c0cf1e1c3566"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("4780def1-0ebf-42f2-85a4-fb91c764f8db"), new Guid("2671c8b7-fd88-4a59-841e-817dd64a0f88"), " Visual Studio Lorem İpsummmmm", "Admin Test", new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(772), null, null, new Guid("299a6cf4-5c0f-433c-9f9f-48a66e99cb70"), null, null, "Visual Studio Deneme Makalesi 1", 15, false },
                    { new Guid("e4f66ada-d6ff-40db-b52b-28a3b2736890"), new Guid("ef3bf98c-a244-4de1-a0ae-a713f671817e"), "Asp.Net Core Lorem İpsummmmm", "Admin Test", new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(767), null, null, new Guid("b1cdbffc-0b49-4b3b-81d8-2fd38b6dd533"), null, null, "Asp.Net Core Deneme Makalesi 1", 15, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2671c8b7-fd88-4a59-841e-817dd64a0f88"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef3bf98c-a244-4de1-a0ae-a713f671817e"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("299a6cf4-5c0f-433c-9f9f-48a66e99cb70"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b1cdbffc-0b49-4b3b-81d8-2fd38b6dd533"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 13, 11, 48, 255, DateTimeKind.Local).AddTicks(2896));
        }
    }
}
