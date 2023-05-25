using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace merketoaspnet.Migrations
{
    /// <inheritdoc />
    public partial class SeedFunctionMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b90fae1-57f4-481e-b2e8-25b1f547e67a",
                column: "ConcurrencyStamp",
                value: "454ed497-d43a-421f-992d-2b27d2828f47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c71aa991-0f56-4b59-b581-fdd57d958bf2",
                column: "ConcurrencyStamp",
                value: "50cbea48-e94b-4cc1-93b3-8ed26227312e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab0d2f8-a950-42fe-af29-456e8bebba1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5a6f425-154e-4ee5-9015-03fe9b48e8c1", "AQAAAAIAAYagAAAAELelCn/vSTqc0cdhRcI89VZacMNCx6QyG1ruZLSsrxtq56Dnd+6M9r2cTKKpW0A+jQ==", "be7e7924-0e49-4e31-ace8-cc4ca992962c" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ArticleNumber", "Description", "Image", "Ingress", "Price", "ProductName", "VendorName" },
                values: new object[,]
                {
                    { "1010", "These headphones will make your life 12%b better if you like music", "https://images.pexels.com/photos/1037992/pexels-photo-1037992.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Best headphones for rock music", "1000", "AmazingSound123", "ABC Headphones" },
                    { "1020", "These headphones will make your life 18% better if you like music", "https://images.pexels.com/photos/1037999/pexels-photo-1037999.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Best headphones for pop music", "2000", "VeryGoodSound123", "ABC Headphones" },
                    { "1030", "Very very very very very good headphones", "https://images.pexels.com/photos/3761020/pexels-photo-3761020.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Best headphones for alternative music", "5000", "VeryAwesomeSound123", "ABC Headphones" },
                    { "1040", "Extremely good and awesome and all around kinda great", "https://images.pexels.com/photos/3394660/pexels-photo-3394660.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Best headphones in 2021", "3000", "GreatSound123", "ABC Headphones" },
                    { "1050", "Extremely okay and okay sound and all around kinda okay headphones", "https://images.pexels.com/photos/3394650/pexels-photo-3394650.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Best of the average headphones in 2019", "1000", "OkaySound123", "ABC Headphones" },
                    { "1060", "If you do not like music but want to own a pair of headphones these are great", "https://images.pexels.com/photos/5081386/pexels-photo-5081386.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Cheap and not very good", "199", "NotVeryGoodSound123", "ABC Headphones" },
                    { "1070", "These are wow. Just wow.", "https://images.pexels.com/photos/3771842/pexels-photo-3771842.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Top quality", "10000", "VeryPro", "ABC Headphones" },
                    { "1080", "These are kinda wow. Just kinda wow.", "https://images.pexels.com/photos/3587496/pexels-photo-3587496.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Almost Top quality", "6000", "KindaPro", "ABC Headphones" },
                    { "1090", "These are almost wow. Just almost wow.", "https://images.pexels.com/photos/2918997/pexels-photo-2918997.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", " Almost Top quality", "8000", "SemiPro", "ABC Headphones" },
                    { "1100", "Buy one of every color. Low price considering the good quality", "https://images.pexels.com/photos/819012/pexels-photo-819012.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Good Headphones", "499", "EverydayMusic", "ABC Headphones" },
                    { "1110", "These work. You can listen to music with them", "https://images.pexels.com/photos/3587475/pexels-photo-3587475.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", " Mastering sound through technology", "20000", "Soundmaster", "ABC Headphones" },
                    { "1120", "If you like classical music you should buy them.", "https://images.pexels.com/photos/3394663/pexels-photo-3394663.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Headphones designed for classical music", "3000", "Classics", "ABC Headphones" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { 4, "New Headphones" },
                    { 5, "Featured headphones" },
                    { 6, "Popular headphones" }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ArticleNumber", "TagId" },
                values: new object[,]
                {
                    { "1010", 4 },
                    { "1020", 4 },
                    { "1030", 4 },
                    { "1040", 4 },
                    { "1050", 5 },
                    { "1060", 5 },
                    { "1070", 5 },
                    { "1080", 5 },
                    { "1090", 6 },
                    { "1100", 6 },
                    { "1110", 6 },
                    { "1120", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1010", 4 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1020", 4 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1030", 4 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1040", 4 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1050", 5 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1060", 5 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1070", 5 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1080", 5 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1090", 6 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1100", 6 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1110", 6 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "1120", 6 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1010");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1020");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1030");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1040");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1050");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1060");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1070");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1080");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1090");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1100");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1110");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1120");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b90fae1-57f4-481e-b2e8-25b1f547e67a",
                column: "ConcurrencyStamp",
                value: "bc1fe5e4-43cc-4cf0-a26c-4a4ada202c92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c71aa991-0f56-4b59-b581-fdd57d958bf2",
                column: "ConcurrencyStamp",
                value: "a27f6a27-1676-4390-9b3b-8c5dd5edf07c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab0d2f8-a950-42fe-af29-456e8bebba1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f027b1f-bee6-4f0d-a639-c9e78be4afc0", "AQAAAAIAAYagAAAAEILNo/h6yLb5+3Jrw8gyvVvPRbwgrfBlJrTQSHDMKtAbjvR5iZSjjigOkEoAjgLyrg==", "373dd07d-e6ad-41af-8c5e-cb559d7a3dfe" });
        }
    }
}
