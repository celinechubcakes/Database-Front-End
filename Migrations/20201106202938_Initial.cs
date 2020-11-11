using Microsoft.EntityFrameworkCore.Migrations;

namespace UNFBooks.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBNNumber = table.Column<int>(nullable: false),
                    BookTitle = table.Column<string>(nullable: true),
                    PublicationDate = table.Column<string>(nullable: true),
                    BookGenre = table.Column<string>(nullable: true),
                    ReadingLevel = table.Column<int>(nullable: false),
                    UserRating = table.Column<int>(nullable: false),
                    UserComments = table.Column<string>(nullable: true),
                    BookSummary = table.Column<string>(nullable: true),
                    RentalPrice = table.Column<decimal>(nullable: false),
                    PurchasePrice = table.Column<decimal>(nullable: false),
                    BookType = table.Column<string>(nullable: true),
                    BookLengthPages = table.Column<decimal>(nullable: false),
                    BookLengthAudio = table.Column<decimal>(nullable: false),
                    AmountInStock = table.Column<int>(nullable: false),
                    BookSeries = table.Column<string>(nullable: true),
                    PublishedEdition = table.Column<int>(nullable: false),
                    BookNewOrUsed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
