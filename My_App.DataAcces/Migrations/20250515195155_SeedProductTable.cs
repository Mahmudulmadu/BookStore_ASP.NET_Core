using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace My_App.DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Lana Wachowski", "Sci-fi action movie with virtual reality themes.", "ISBN0001", 40.0, 35.0, 25.0, 30.0, "The Matrix" },
                    { 2, "Christopher Nolan", "A science fiction exploration of space and time.", "ISBN0002", 45.0, 40.0, 32.0, 36.0, "Interstellar" },
                    { 3, "Sun Tzu", "Ancient Chinese military treatise.", "ISBN0003", 30.0, 28.0, 22.0, 25.0, "The Art of War" },
                    { 4, "George Orwell", "Dystopian novel set in a totalitarian future.", "ISBN0004", 38.0, 34.0, 27.0, 30.0, "1984" },
                    { 5, "Aldous Huxley", "A futuristic society with engineered citizens.", "ISBN0005", 42.0, 37.0, 29.0, 33.0, "Brave New World" },
                    { 6, "Yuval Noah Harari", "A brief history of humankind.", "ISBN0006", 50.0, 45.0, 35.0, 40.0, "Sapiens" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
