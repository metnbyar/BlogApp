using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("14a9ef68-b2c0-4388-b0d5-01c7ce746b33"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2c2b0b17-9829-4272-afde-c0cf1e1c3566"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "ModifiedBy", "ModifiedDate", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("ab7fb0fc-d7d2-441b-aec3-d9cf61403f8f"), new Guid("ef3bf98c-a244-4de1-a0ae-a713f671817e"), "Asp.Net Core Lorem İpsummmmm", "Admin Test", new DateTime(2025, 6, 12, 18, 17, 37, 327, DateTimeKind.Local).AddTicks(7352), null, null, new Guid("b1cdbffc-0b49-4b3b-81d8-2fd38b6dd533"), null, null, "Asp.Net Core Deneme Makalesi 1", 15, false },
                    { new Guid("d0ef31d3-3f0c-47ca-8dd3-f95981733540"), new Guid("2671c8b7-fd88-4a59-841e-817dd64a0f88"), " Visual Studio Lorem İpsummmmm", "Admin Test", new DateTime(2025, 6, 12, 18, 17, 37, 327, DateTimeKind.Local).AddTicks(7357), null, null, new Guid("299a6cf4-5c0f-433c-9f9f-48a66e99cb70"), null, null, "Visual Studio Deneme Makalesi 1", 15, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("bdea8c46-7f11-4af4-af0c-d733719f292e"), "ba1843e0-f46b-4da1-920d-e9d03edb182d", "Superadmin", "SUPERADMIN" },
                    { new Guid("c6b83f32-360f-4ddf-9859-dfc2a4cfeae4"), "20078edc-b4be-481e-9212-c6a974304317", "User", "USER" },
                    { new Guid("d4a9834e-545e-46c3-800a-d327c375cae5"), "f9d7f1a8-5df3-4057-b4fb-a7f305f3ae59", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4d75b4ba-8e8a-443a-8bb0-3ccc01d27144"), 0, "44a69f08-02e3-43a4-b492-502f6d3cb9cc", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEF106cJ59jXTsXouMaNwwhuIiGEB+DWmgvlDk6Uvhv4JXZ7chO/wxeK+n4QAVNZadA==", "+905439999988", false, "d571dd48-3256-4960-9e87-a59ece3d7115", false, "admin@gmail.com" },
                    { new Guid("e5469f4f-4578-4c4b-9587-01ee9b023b3f"), 0, "bcda671e-e0ea-4c7e-9f9f-e85a3e459810", "superadmin@gmail.com", true, "Metin", "Bayar", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAECt57PU1d6VB8QCrxVvGC0SJUqCtVz7u7f0lXUHaXFRzl/c6KXOeNk1NSMwbFyJTmw==", "+905439999999", true, "7cd31b70-0119-4f5d-bcd0-3a8b52f3ffb6", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2671c8b7-fd88-4a59-841e-817dd64a0f88"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 18, 17, 37, 327, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef3bf98c-a244-4de1-a0ae-a713f671817e"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 18, 17, 37, 327, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("299a6cf4-5c0f-433c-9f9f-48a66e99cb70"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 18, 17, 37, 328, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b1cdbffc-0b49-4b3b-81d8-2fd38b6dd533"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 18, 17, 37, 328, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d4a9834e-545e-46c3-800a-d327c375cae5"), new Guid("4d75b4ba-8e8a-443a-8bb0-3ccc01d27144") },
                    { new Guid("bdea8c46-7f11-4af4-af0c-d733719f292e"), new Guid("e5469f4f-4578-4c4b-9587-01ee9b023b3f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ab7fb0fc-d7d2-441b-aec3-d9cf61403f8f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d0ef31d3-3f0c-47ca-8dd3-f95981733540"));

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
    }
}
