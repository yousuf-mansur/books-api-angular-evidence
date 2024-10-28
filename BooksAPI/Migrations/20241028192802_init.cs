using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    BookCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => x.BookCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBNNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Writer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandardCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ListPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Edition = table.Column<int>(type: "int", nullable: false),
                    Pages = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_BookCategory_BookCategoryId",
                        column: x => x.BookCategoryId,
                        principalTable: "BookCategory",
                        principalColumn: "BookCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BookCategory",
                columns: new[] { "BookCategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Non-Fiction" },
                    { 3, "Mystery" },
                    { 4, "Romance" },
                    { 5, "Biography" },
                    { 6, "History" },
                    { 7, "Science Fiction" },
                    { 8, "Fantasy" },
                    { 9, "Self-Help" },
                    { 10, "Cookbooks" },
                    { 11, "Poetry" },
                    { 12, "Travel" },
                    { 13, "Business" },
                    { 14, "Art & Photography" },
                    { 15, "Technology" },
                    { 16, "Philosophy" },
                    { 17, "True Crime" },
                    { 18, "Horror" },
                    { 19, "Graphic Novels" },
                    { 20, "Health & Wellness" },
                    { 21, "Psychology" },
                    { 22, "Political Science" },
                    { 23, "Music" },
                    { 24, "Religion & Spirituality" },
                    { 25, "Science & Nature" },
                    { 26, "Parenting" },
                    { 27, "Sports" },
                    { 28, "Anthropology" },
                    { 29, "Education" },
                    { 30, "Classics" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "BookCategoryId", "BookName", "Edition", "ISBNNumber", "ListPrice", "Pages", "StandardCost", "Writer" },
                values: new object[,]
                {
                    { 1, 1, "To Kill a Mockingbird", 1, "978-0-06-093546-5", 14.99m, 281m, 8.99m, "Harper Lee" },
                    { 2, 7, "1984", 1, "978-0-451-52493-5", 16.99m, 328m, 9.99m, "George Orwell" },
                    { 3, 1, "The Great Gatsby", 1, "978-0-7432-7356-5", 17.99m, 180m, 10.99m, "F. Scott Fitzgerald" },
                    { 4, 7, "The Hunger Games", 1, "978-0-439-02352-8", 19.99m, 374m, 11.99m, "Suzanne Collins" },
                    { 5, 5, "The Diary of a Young Girl", 1, "978-0-553-57712-8", 12.99m, 283m, 7.99m, "Anne Frank" },
                    { 6, 4, "Pride and Prejudice", 1, "978-0-141-43951-8", 14.99m, 279m, 8.99m, "Jane Austen" },
                    { 7, 1, "The Kite Runner", 1, "978-1-59448-000-3", 19.99m, 371m, 11.99m, "Khaled Hosseini" },
                    { 8, 1, "The Book Thief", 1, "978-0-375-84220-7", 17.99m, 572m, 10.99m, "Markus Zusak" },
                    { 9, 3, "The Girl on the Train", 1, "978-1-59463-369-6", 16.99m, 323m, 9.99m, "Paula Hawkins" },
                    { 10, 9, "The Life-Changing Magic of Tidying Up", 1, "978-1-60774-818-4", 21.99m, 224m, 12.99m, "Marie Kondo" },
                    { 11, 2, "Sapiens: A Brief History of Humankind", 1, "978-0-062-31622-7", 24.99m, 443m, 14.99m, "Yuval Noah Harari" },
                    { 12, 8, "The Lord of the Rings", 2, "978-0-618-64015-7", 27.99m, 1178m, 15.99m, "J.R.R. Tolkien" },
                    { 13, 17, "In Cold Blood", 1, "978-0-679-74558-7", 19.99m, 343m, 11.99m, "Truman Capote" },
                    { 14, 18, "The Shining", 1, "978-0-307-74365-7", 21.99m, 447m, 12.99m, "Stephen King" },
                    { 15, 16, "The Republic", 2, "978-0-465-06934-7", 16.99m, 416m, 9.99m, "Plato" },
                    { 16, 21, "Thinking, Fast and Slow", 1, "978-0-374-53355-7", 22.99m, 499m, 13.99m, "Daniel Kahneman" },
                    { 17, 16, "The Art of War", 1, "978-0-486-42556-3", 9.99m, 273m, 5.99m, "Sun Tzu" },
                    { 18, 25, "A Brief History of Time", 1, "978-0-553-17698-7", 18.99m, 256m, 10.99m, "Stephen Hawking" },
                    { 19, 13, "Good to Great", 1, "978-0-060-52685-4", 20.99m, 320m, 11.99m, "Jim Collins" },
                    { 20, 5, "Becoming", 1, "978-0-525-57507-2", 23.99m, 448m, 13.99m, "Michelle Obama" },
                    { 21, 9, "The 7 Habits of Highly Effective People", 1, "978-0-7432-6951-0", 21.99m, 372m, 12.99m, "Stephen R. Covey" },
                    { 22, 24, "The Art of Happiness", 1, "978-1-57322-111-5", 17.99m, 320m, 10.99m, "Dalai Lama" },
                    { 23, 22, "Freakonomics", 1, "978-0-06-073132-6", 16.99m, 336m, 9.99m, "Steven D. Levitt, Stephen J. Dubner" },
                    { 24, 30, "The Catcher in the Rye", 1, "978-0-316-76948-0", 14.99m, 277m, 8.99m, "J.D. Salinger" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_BookCategoryId",
                table: "Book",
                column: "BookCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "BookCategory");
        }
    }
}
