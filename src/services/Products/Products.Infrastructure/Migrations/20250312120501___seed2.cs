using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.Infrastructure.Migrations
{
    public partial class __seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CategoryId", "Description", "ModificationDateTime", "Price", "Title" },
                values: new object[,]
                {
                    { 1, true, 2, "گوشی موبایل سامسونگ مدل Galaxy S21", null, 20000m, "گوشی موبایل سامسونگ" },
                    { 2, true, 3, "لپ‌تاپ ایسوس مدل ZenBook Pro", null, 30000m, "لپ‌تاپ ایسوس" },
                    { 3, true, 4, "کیبورد گیمینگ برند ریزر مدل BlackWidow", null, 5000m, "کیبورد گیمینگ" },
                    { 4, true, 4, "کامپیوتر رومیزی برند Dell مدل XPS", null, 40000m, "کامپیوتر رومیزی Dell" },
                    { 5, true, 5, "یخچال سامسونگ مدل Side by Side", null, 15000m, "یخچال سامسونگ" },
                    { 6, true, 2, "گوشی موبایل آیفون 13 با پردازنده A15 Bionic", null, 25000m, "گوشی موبایل آیفون 13" },
                    { 7, true, 3, "لپ‌تاپ اپل مک‌بوک پرو 16 اینچ", null, 35000m, "لپ‌تاپ اپل مک‌بوک پرو" },
                    { 8, true, 2, "تبلت اپل آیپد پرو 12.9 اینچ", null, 22000m, "تبلت آیپد پرو" },
                    { 9, true, 4, "مانیتور 4K برند سامسونگ مدل U32J590", null, 8000m, "مانیتور 4K سامسونگ" },
                    { 10, true, 4, "ماوس گیمینگ ریزر مدل DeathAdder", null, 1500m, "ماوس گیمینگ ریزر" },
                    { 11, true, 5, "ماشین لباسشویی بوش مدل Serie 8", null, 12000m, "ماشین لباسشویی بوش" },
                    { 12, true, 5, "یخچال ساید بای ساید ال‌جی مدل GR-B247JDS", null, 18000m, "یخچال ساید بای ساید ال‌جی" },
                    { 13, true, 3, "لپ‌تاپ اچ‌پی مدل Spectre x360", null, 33000m, "لپ‌تاپ اچ‌پی" },
                    { 14, true, 1, "دوربین دیجیتال کانن مدل EOS 90D", null, 12000m, "دوربین دیجیتال کانن" },
                    { 15, true, 1, "پاور بانک انکر مدل PowerCore 10000", null, 1200m, "پاور بانک انکر" },
                    { 16, true, 1, "هارد اکسترنال وسترن دیجیتال مدل My Passport", null, 2500m, "هارد اکسترنال وسترن دیجیتال" },
                    { 17, true, 1, "اسپیکر بلوتوثی جی‌بی‌ال مدل Flip 5", null, 3500m, "اسپیکر بلوتوثی جی‌بی‌ال" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
