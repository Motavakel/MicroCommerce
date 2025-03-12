using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class __seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    BannerUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/500x100.png"),
                    IconUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/85.png"),
                    ThumbnailUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/150.png"),
                    ParentCategoryId = table.Column<int>(type: "integer", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/150x150.png"),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ModificationDateTime", "ParentCategoryId", "Priority", "Title" },
                values: new object[,]
                {
                    { 1, true, "انواع دستگاه‌های دیجیتال مانند گوشی موبایل، لپ‌تاپ و...", null, null, 1, "کالای دیجیتال" },
                    { 5, true, "لوازم خانگی و آشپزخانه‌ای از جمله یخچال، ماشین لباسشویی و...", null, null, 5, "لوازم خانه و آشپزخانه" },
                    { 2, true, "گوشی‌های هوشمند و جدیدترین مدل‌های برندهای معروف.", null, 1, 2, "گوشی موبایل" },
                    { 3, true, "انواع لپ‌تاپ‌ها و نوت‌بوک‌های برندهای مختلف.", null, 1, 3, "لپ‌تاپ" },
                    { 4, true, "قطعات کامپیوتر، ماوس، کیبورد و سایر لوازم جانبی.", null, 1, 4, "کامپیوتر و لوازم جانبی" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
