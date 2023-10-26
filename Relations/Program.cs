using Microsoft.EntityFrameworkCore;
using Relations.Migrations;
using System.Linq;
using System.Net;
using static System.Reflection.Metadata.BlobBuilder;

namespace EFECore;
class Program
{
    public static void Main(String[] args) { 
        //insertDummyData();
        ApplicationDbContext context = new ApplicationDbContext();
        //var stock = context.Stocks.Find(11);
        //Console.WriteLine("Find => " + stock.Name);

        //var stockSingle = context.Stocks.Single(m => 
        //    m.Id == 100 
        //);
        //Console.WriteLine("stockSingle => " + stockSingle.Name);

        //var stockFirst = context.Stocks.First();
        //Console.WriteLine("stockFirst => " + stockFirst.Name);


        //var stockFirst2 = context.Stocks.First( s => s.Id > 500);
        //Console.WriteLine("stockFirst2 => " + "Id : "+ stockFirst2.Id+ ": " + stockFirst2.Name);


        //var stockFirstOrDefault = context.Stocks.FirstOrDefault(s => s.Id > 1000);
        //if(stockFirstOrDefault != null)
        //Console.WriteLine("stockFirstOrDefault => " + "Id : " + stockFirstOrDefault.Id + ": " + stockFirstOrDefault.Name);
        //else 
        //Console.WriteLine("No Item Found");



        //var stockLastOrDefault = context.Stocks.OrderBy(s=>s.Name).Last();
        //if (stockLastOrDefault != null)
        //    Console.WriteLine("stockLastOrDefault => " + "Id : " + stockLastOrDefault.Id + ": " + stockLastOrDefault.Name);
        //else
        //    Console.WriteLine("No Item Found");
        //stockLastOrDefault = context.Stocks.OrderBy(s => s.Name).Last( s => s.Id > 700);
        //if (stockLastOrDefault != null)
        //    Console.WriteLine("stockLastOrDefault => " + "Id : " + stockLastOrDefault.Id + ": " + stockLastOrDefault.Name);
        //else
        //    Console.WriteLine("No Item Found");
        //stockLastOrDefault = context.Stocks.OrderBy(s => s.Name).LastOrDefault(s => s.Id > 2000);
        //if (stockLastOrDefault != null)
        //    Console.WriteLine("stockLastOrDefault => " + "Id : " + stockLastOrDefault.Id + ": " + stockLastOrDefault.Name);
        //else
        //    Console.WriteLine("No Item Found");




        //var max = context.Stocks.Max(s => s.Balance);

        //Console.WriteLine(max);
        //var min = context.Stocks.Min(s => s.Balance);

        //Console.WriteLine(min);
        //var avg = context.Stocks.Average(m => m.Balance);
        //Console.WriteLine(avg);
        //var Sum = context.Stocks.Sum(m => m.Balance);
        //Console.WriteLine(Sum);


        //var stocks = context.Stocks.Skip(990).Take(3).OrderByDescending( s => s.Balance).ThenBy(s => s.Name).ToList();
        //foreach (var stock in stocks)
        //    Console.WriteLine($" id : {stock.Id} Name : {stock.Name}  Balance : {stock.Balance}");



        //var stocks = context.Stocks
        //    .GroupBy (x => x.Industry)
        //    .Select( m=> new { industry = m.Key , count = m.Count() , sum = m.Sum( m=> m.Balance) , avg = m.Average( m=> m.Balance)} )
        //    .OrderByDescending(m => m.count)
        //    .ToList();
        //foreach (var stock in stocks)
        //{
        //    Console.WriteLine($" Name : {stock.industry} Count : {stock.count}  sum : {stock.sum}  avg : {stock.avg}");
        //}


        // join 
        //var joinBooks = context.Books
        //    .Join(
        //    context.Authors,
        //    book => book.AuthorId,
        //    author => author.Id,
        //    (book , author) => new {
        //        Id = book.Id,
        //        AuthorId = book.AuthorId,
        //        Title = book.Title,
        //        Author = author
        //    }
        //    );
        //var joinBooks = context.Books
        //   .Join(
        //   context.Authors,
        //   book => book.AuthorId,
        //   author => author.Id,
        //   (book, author) => new {
        //       Id = book.Id,
        //       AuthorId = book.AuthorId,
        //       Title = book.Title,
        //       Author = author
        //   }
        //   )

        //   .Join(
        //        context.Nationality ,
        //        books => books.Author.NationalityId,
        //        n => n.Id,
        //        (books , n) => new { 
        //            n,
        //            books
        //        }
        //   )
        //   ;


        //var LeftjoinBooks = context.Books
        //   .Join(
        //   context.Authors,
        //   book => book.AuthorId,
        //   author => author.Id,
        //   (book, author) => new {
        //       bookId = book.Id,
        //       bookTitle = book.Title,
        //       AuthorName = author.Name,
        //       author.NationalityId
        //   }
        //   )

        //   .GroupJoin(
        //        context.Nationality,
        //        books => books.NationalityId,
        //        n => n.Id,
        //        (books, nationality) => new {
        //            book = books,
        //            Nationality = nationality
        //        }
        //   ).SelectMany(
        //        b=>b.Nationality.DefaultIfEmpty(),
        //        (b, n) => new {
        //            b.book,
        //            Nationality = n
        //        }
        //    )
        //   ;
        //var books = context.Books
        //    .Join(
        //    context.Authors, 
        //    book =>book.AuthorId, 
        //    author => author.Id, 
        //    (book, author) => new
        //    {
        //        BookId = book.Id,
        //        BookName = book.Title,
        //        AuthorName = author.Name,
        //        AuthorNationalityId = author.NationalityId
        //    }
        //    )
        //    .GroupJoin(
        //    context.Nationality,
        //    book => book.AuthorNationalityId,
        //    nationality => nationality.Id,
        //    (book, nationality) => new
        //    {
        //        Book = book,
        //        Nationality = nationality
        //    }
        //    )
        //    .SelectMany(
        //            b => b.Nationality.DefaultIfEmpty(),
        //            (b, n) => new { b.Book, Nationality = n }
        //    );
        //    foreach (var book in books)
        //                System.Console.WriteLine($" {book.Book.BookId} - {book.Book.BookName} {book.Book.BookName} - {book.Book.AuthorName} - {book.Nationality?.Name}");



        var books = context.Books
    .Join(
        context.Authors,
        book => book.AuthorId,
        author => author.Id,
        (book, author) => new
        {
            BookId = book.Id,
            BookName = book.Title,
            AuthorName = author.Name,
            AuthorNationalityId = author.NationalityId
        }
    )
    .GroupJoin(
        context.Nationality,
        book => book.AuthorNationalityId,
        nationality => nationality.Id,
        (book, nationality) => new
        {
            Book = book,
            Nationality = nationality
        }
    )
    .SelectMany(
        b => b.Nationality.DefaultIfEmpty(),
        (b, n) => new { b.Book, Nationality = n }
    );

        foreach (var book in books)
            System.Console.WriteLine($" {book.Book.BookId} - {book.Book.BookName} {book.Book.BookName} - {book.Book.AuthorName} - {book.Nationality?.Name}");


        //foreach (var book in LeftjoinBooks)
        //{
        //    //Console.WriteLine($" Book Name is {book.books.Title} , it's Author is {book.books.Author.Name} , his/her Nationality is {book.n?.Name}");
        //    //Console.WriteLine($" Book Name is {book.books.Title} , it's Author is {book.books.Author.Name}");
        //}

        // Eager Loading
        //List<Book> books = context.Books.Include( b=> b.Author).ToList();
        //foreach (var book in books)
        //{
        //    Console.WriteLine($" Book Name is {book.Title} , it's Author is ${book.Author.Name}");
        //}


        // Explicit Loading
        //List<Book> books2 = context.Books.ToList();
        //foreach (var book in books2)
        //{
        //    context.Entry(book).Reference(b => b.Author).Load();
        //    Console.WriteLine($" Book Name is {book.Title} , it's Author is ${book.Author.Name}");
        //}
    }

    public static void insertDummyData() {

        // Create some test authors
        var author1 = new Author { Name = "J.K. Rowling",  NationalityId = 1 };
        var author2 = new Author { Name = "George Orwell", NationalityId = 1 };
        var author3 = new Author { Name = "Harper Lee", NationalityId = 3 };
        var author4 = new Author { Name = "Jane Austen", NationalityId = 1 };
        var author5 = new Author { Name = "Fyodor Dostoevsky",NationalityId = 5 };

        // Create some test books
        var book1 = new Book { Title = "Harry Potter and the Sorcerer's Stone", Author = author1 };
        var book2 = new Book { Title = "1984", Author = author2 };
        var book3 = new Book { Title = "To Kill a Mockingbird", Author = author3 };
        var book4 = new Book { Title = "Pride and Prejudice", Author = author4 };
        var book5 = new Book { Title = "Crime and Punishment", Author = author5 };

        // Add more test authors
        var author6 = new Author { Name = "Mark Twain", NationalityId = 3};
        var author7 = new Author { Name = "Ernest Hemingway", NationalityId = 3};
        var author8 = new Author { Name = "Leo Tolstoy",NationalityId = 5 };

        // Add more test books
        var book6 = new Book { Title = "The Adventures of Tom Sawyer", Author = author6 };
        var book7 = new Book { Title = "The Old Man and the Sea", Author = author7 };
        var book8 = new Book { Title = "Anna Karenina", Author = author8 };

        // Add the authors and books to the database
        using (var context = new ApplicationDbContext())
        {
            context.Authors.AddRange(author1, author2, author3, author4, author5, author6, author7, author8);
            context.Books.AddRange(book1, book2, book3, book4, book5, book6, book7, book8);
            context.SaveChanges();
        }
    }

}