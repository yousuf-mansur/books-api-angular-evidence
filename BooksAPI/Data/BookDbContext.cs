using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksAPI.Models;

namespace BooksAPI.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookCategory> BookCategories { get; set; } = default!;
        public DbSet<Book> Books {  get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=SARKARPALACE\SQLEXPRESS;Database=BooksDB;Trusted_Connection=True; TrustServerCertificate=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>().HasData(new BookCategory[]
            {
        new BookCategory { BookCategoryId = 1, CategoryName = "Fiction" },
        new BookCategory { BookCategoryId = 2, CategoryName = "Non-Fiction" },
        new BookCategory { BookCategoryId = 3, CategoryName = "Mystery" },
        new BookCategory { BookCategoryId = 4, CategoryName = "Romance" },
        new BookCategory { BookCategoryId = 5, CategoryName = "Biography" },
        new BookCategory { BookCategoryId = 6, CategoryName = "History" },
        new BookCategory { BookCategoryId = 7, CategoryName = "Science Fiction" },
        new BookCategory { BookCategoryId = 8, CategoryName = "Fantasy" },
        new BookCategory { BookCategoryId = 9, CategoryName = "Self-Help" },
        new BookCategory { BookCategoryId = 10, CategoryName = "Cookbooks" },
        // New categories
        new BookCategory { BookCategoryId = 11, CategoryName = "Poetry" },
        new BookCategory { BookCategoryId = 12, CategoryName = "Travel" },
        new BookCategory { BookCategoryId = 13, CategoryName = "Business" },
        new BookCategory { BookCategoryId = 14, CategoryName = "Art & Photography" },
        new BookCategory { BookCategoryId = 15, CategoryName = "Technology" },
        new BookCategory { BookCategoryId = 16, CategoryName = "Philosophy" },
        new BookCategory { BookCategoryId = 17, CategoryName = "True Crime" },
        new BookCategory { BookCategoryId = 18, CategoryName = "Horror" },
        new BookCategory { BookCategoryId = 19, CategoryName = "Graphic Novels" },
        new BookCategory { BookCategoryId = 20, CategoryName = "Health & Wellness" },
        new BookCategory { BookCategoryId = 21, CategoryName = "Psychology" },
        new BookCategory { BookCategoryId = 22, CategoryName = "Political Science" },
        new BookCategory { BookCategoryId = 23, CategoryName = "Music" },
        new BookCategory { BookCategoryId = 24, CategoryName = "Religion & Spirituality" },
        new BookCategory { BookCategoryId = 25, CategoryName = "Science & Nature" },
        new BookCategory { BookCategoryId = 26, CategoryName = "Parenting" },         // No books
        new BookCategory { BookCategoryId = 27, CategoryName = "Sports" },            // No books
        new BookCategory { BookCategoryId = 28, CategoryName = "Anthropology" },      // No books
        new BookCategory { BookCategoryId = 29, CategoryName = "Education" },
        new BookCategory { BookCategoryId = 30, CategoryName = "Classics" }
            });

            modelBuilder.Entity<Book>().HasData(new Book[]
            {
        // Existing books
        new Book
        {
            BookId = 1,
            BookName = "To Kill a Mockingbird",
            ISBNNumber = "978-0-06-093546-5",
            Writer = "Harper Lee",
            StandardCost = 8.99M,
            ListPrice = 14.99M,
            Edition = 1,
            Pages = 281,
            BookCategoryId = 1
        },
        new Book
        {
            BookId = 2,
            BookName = "1984",
            ISBNNumber = "978-0-451-52493-5",
            Writer = "George Orwell",
            StandardCost = 9.99M,
            ListPrice = 16.99M,
            Edition = 1,
            Pages = 328,
            BookCategoryId = 7
        },
        new Book
        {
            BookId = 3,
            BookName = "The Great Gatsby",
            ISBNNumber = "978-0-7432-7356-5",
            Writer = "F. Scott Fitzgerald",
            StandardCost = 10.99M,
            ListPrice = 17.99M,
            Edition = 1,
            Pages = 180,
            BookCategoryId = 1
        },
        new Book
        {
            BookId = 4,
            BookName = "The Hunger Games",
            ISBNNumber = "978-0-439-02352-8",
            Writer = "Suzanne Collins",
            StandardCost = 11.99M,
            ListPrice = 19.99M,
            Edition = 1,
            Pages = 374,
            BookCategoryId = 7
        },
        new Book
        {
            BookId = 5,
            BookName = "The Diary of a Young Girl",
            ISBNNumber = "978-0-553-57712-8",
            Writer = "Anne Frank",
            StandardCost = 7.99M,
            ListPrice = 12.99M,
            Edition = 1,
            Pages = 283,
            BookCategoryId = 5
        },
        new Book
        {
            BookId = 6,
            BookName = "Pride and Prejudice",
            ISBNNumber = "978-0-141-43951-8",
            Writer = "Jane Austen",
            StandardCost = 8.99M,
            ListPrice = 14.99M,
            Edition = 1,
            Pages = 279,
            BookCategoryId = 4
        },
        new Book
        {
            BookId = 7,
            BookName = "The Kite Runner",
            ISBNNumber = "978-1-59448-000-3",
            Writer = "Khaled Hosseini",
            StandardCost = 11.99M,
            ListPrice = 19.99M,
            Edition = 1,
            Pages = 371,
            BookCategoryId = 1
        },
        new Book
        {
            BookId = 8,
            BookName = "The Book Thief",
            ISBNNumber = "978-0-375-84220-7",
            Writer = "Markus Zusak",
            StandardCost = 10.99M,
            ListPrice = 17.99M,
            Edition = 1,
            Pages = 572,
            BookCategoryId = 1
        },
        new Book
        {
            BookId = 9,
            BookName = "The Girl on the Train",
            ISBNNumber = "978-1-59463-369-6",
            Writer = "Paula Hawkins",
            StandardCost = 9.99M,
            ListPrice = 16.99M,
            Edition = 1,
            Pages = 323,
            BookCategoryId = 3
        },
        new Book
        {
            BookId = 10,
            BookName = "The Life-Changing Magic of Tidying Up",
            ISBNNumber = "978-1-60774-818-4",
            Writer = "Marie Kondo",
            StandardCost = 12.99M,
            ListPrice = 21.99M,
            Edition = 1,
            Pages = 224,
            BookCategoryId = 9
        },
        // New books
        new Book
        {
            BookId = 11,
            BookName = "Sapiens: A Brief History of Humankind",
            ISBNNumber = "978-0-062-31622-7",
            Writer = "Yuval Noah Harari",
            StandardCost = 14.99M,
            ListPrice = 24.99M,
            Edition = 1,
            Pages = 443,
            BookCategoryId = 2
        },
        new Book
        {
            BookId = 12,
            BookName = "The Lord of the Rings",
            ISBNNumber = "978-0-618-64015-7",
            Writer = "J.R.R. Tolkien",
            StandardCost = 15.99M,
            ListPrice = 27.99M,
            Edition = 2,
            Pages = 1178,
            BookCategoryId = 8
        },
        new Book
        {
            BookId = 13,
            BookName = "In Cold Blood",
            ISBNNumber = "978-0-679-74558-7",
            Writer = "Truman Capote",
            StandardCost = 11.99M,
            ListPrice = 19.99M,
            Edition = 1,
            Pages = 343,
            BookCategoryId = 17
        },
        new Book
        {
            BookId = 14,
            BookName = "The Shining",
            ISBNNumber = "978-0-307-74365-7",
            Writer = "Stephen King",
            StandardCost = 12.99M,
            ListPrice = 21.99M,
            Edition = 1,
            Pages = 447,
            BookCategoryId = 18
        },
        new Book
        {
            BookId = 15,
            BookName = "The Republic",
            ISBNNumber = "978-0-465-06934-7",
            Writer = "Plato",
            StandardCost = 9.99M,
            ListPrice = 16.99M,
            Edition = 2,
            Pages = 416,
            BookCategoryId = 16
        },
        new Book
        {
            BookId = 16,
            BookName = "Thinking, Fast and Slow",
            ISBNNumber = "978-0-374-53355-7",
            Writer = "Daniel Kahneman",
            StandardCost = 13.99M,
            ListPrice = 22.99M,
            Edition = 1,
            Pages = 499,
            BookCategoryId = 21
        },
        new Book
        {
            BookId = 17,
            BookName = "The Art of War",
            ISBNNumber = "978-0-486-42556-3",
            Writer = "Sun Tzu",
            StandardCost = 5.99M,
            ListPrice = 9.99M,
            Edition = 1,
            Pages = 273,
            BookCategoryId = 16
        },
        new Book
        {
            BookId = 18,
            BookName = "A Brief History of Time",
            ISBNNumber = "978-0-553-17698-7",
            Writer = "Stephen Hawking",
            StandardCost = 10.99M,
            ListPrice = 18.99M,
            Edition = 1,
            Pages = 256,
            BookCategoryId = 25
        },
        new Book
        {
            BookId = 19,
            BookName = "Good to Great",
            ISBNNumber = "978-0-060-52685-4",
            Writer = "Jim Collins",
            StandardCost = 11.99M,
            ListPrice = 20.99M,
            Edition = 1,
            Pages = 320,
            BookCategoryId = 13
        },
        new Book
        {
            BookId = 20,
            BookName = "Becoming",
            ISBNNumber = "978-0-525-57507-2",
            Writer = "Michelle Obama",
            StandardCost = 13.99M,
            ListPrice = 23.99M,
            Edition = 1,
            Pages = 448,
            BookCategoryId = 5
        },
        new Book
        {
            BookId = 21,
            BookName = "The 7 Habits of Highly Effective People",
            ISBNNumber = "978-0-7432-6951-0",
            Writer = "Stephen R. Covey",
            StandardCost = 12.99M,
            ListPrice = 21.99M,
            Edition = 1,
            Pages = 372,
            BookCategoryId = 9
        },
        new Book
        {
            BookId = 22,
            BookName = "The Art of Happiness",
            ISBNNumber = "978-1-57322-111-5",
            Writer = "Dalai Lama",
            StandardCost = 10.99M,
            ListPrice = 17.99M,
            Edition = 1,
            Pages = 320,
            BookCategoryId = 24
        },
        new Book
        {
            BookId = 23,
            BookName = "Freakonomics",
            ISBNNumber = "978-0-06-073132-6",
            Writer = "Steven D. Levitt, Stephen J. Dubner",
            StandardCost = 9.99M,
            ListPrice = 16.99M,
            Edition = 1,
            Pages = 336,
            BookCategoryId = 22
        },
        new Book
        {
            BookId = 24,
            BookName = "The Catcher in the Rye",
            ISBNNumber = "978-0-316-76948-0",
            Writer = "J.D. Salinger",
            StandardCost = 8.99M,
            ListPrice = 14.99M,
            Edition = 1,
            Pages = 277,
            BookCategoryId = 30
        }
            });
        }
    }
}
