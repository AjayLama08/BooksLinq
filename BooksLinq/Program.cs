// See https://aka.ms/new-console-template for more information
using BooksLinq;


static void DisplayBookList(List<Book> bookList)
{
    foreach (var book in bookList)
    {
        Console.WriteLine(book);
    }
}


Console.WriteLine("Book List LINQ\n");

var books = new List<Book>
{
   new Book(1, "The Catcher in the Rye", "J.D. Salinger", 277, "Little, Brown and Company", 1951, "Fiction", true),
   new Book(2, "War and Peace", "Leo Tolstoy", 1225, "The Russian Messenger(serial)", 1869, "Historical Fiction", true),
   new Book(3, "1984", "George Orwell", 328, "Secker & Warburg", 1949, "Dystopian", true)
};



books.AddRange(new List<Book>
{
new Book(4, "The Hobbit", "J.R.R. Tolkien", 310,
"George Allen & Unwin", 1937, "Fantasy", true),
new Book(5, "Tender Is the Night", "F. Scott Fitzgerald", 317,
"Charles Scribner", 1934, "Fiction", true),
new Book(6, "The Great Gatsby", "F. Scott Fitzgerald", 180,
"Charles Scribner", 1925, "Fiction", true),
new Book(7, "To Kill a Mockingbird", "Harper Lee", 336,
"J.B. Lippincott & Co.", 1960, "Fiction", true),
new Book(8, "The Alchemist", "Paulo Coelho", 208,
"HarperTorch", 1988, "Adventure", true),
new Book(9, "Brave New World", "Aldous Huxley", 268,
"Chatto & Windus", 1932, "Dystopian", true),
new Book(10, "Moby-Dick", "Herman Melville", 635,
"Harper & Brothers", 1851, "Adventure", true),
new Book(11, "Pride and Prejudice", "Jane Austen", 279,
"T. Egerton, Whitehall", 1813, "Romance", true),
new Book(12, "The Lord of the Rings", "J.R.R. Tolkien", 1178,
"George Allen & Unwin", 1954, "Fantasy", true),
new Book(13, "Becoming", "Michelle Obama", 448,
"Crown", 2018, "Autobiography", false),
new Book(14, "Sapiens: A Brief History of Humankind", "Yuval Harari", 443,
"Harper", 2011, "Non-Fiction", false),
new Book(15, "Educated", "Tara Westover", 334,
"Random House", 2018, "Autobiography", false),
new Book(17, "Thinking, Fast and Slow", "Daniel Kahneman", 499,
"Farrar, Straus and Giroux", 2011, "Non-Fiction", false),
new Book(18, "The Body Keeps the Score", "Bessel van der Kolk", 464,
"Viking", 2014, "Non-Fiction", false)
}
);

//DisplayBookList(books);

//Console.WriteLine("\nTolkien Books");
//var tolkienBooks = books.Where(b => b.Author == "J.R.R. Tolkien").ToList();
//DisplayBookList(tolkienBooks);

//Console.WriteLine("\nTolkien Or Coelho Books");
//var tolkienOrCoelhoBooks = books.Where(b => b.Author == "J.R.R. Tolkien" || b.Author == "Paulo Coelho").ToList();
//DisplayBookList(tolkienOrCoelhoBooks);

//Console.WriteLine("\nBooks with IS in the title");
//var isBooks = books.Where(b => b.Title.Contains("is", StringComparison.CurrentCultureIgnoreCase)).ToList();
//DisplayBookList(isBooks);

//Console.WriteLine("\nBooks with a page count between 450 and 1000 inclusive");
//var mediumSizeBooks = books.Where(b => b.PageCount >= 450 && b.PageCount <= 1000).ToList();
//DisplayBookList(mediumSizeBooks);

//Console.WriteLine("\nBooks in the Autobiography and Romance Genre");
//var genreFilterList = new List<string> { "Autobiography", "Romance" };
//var genreFilteredList = books.Where(b => genreFilterList.Contains(b.Genre)).ToList();
//DisplayBookList(genreFilteredList);

//Console.WriteLine("\nBooks sorted by Genre");
//var booksSortedByGenre = books.OrderBy(b => b.Genre).ToList();
//DisplayBookList(booksSortedByGenre);

//Console.WriteLine("\nBooks sorted by Genre and Title");
//var booksSortedByGenreAndTitle = books.OrderBy(b => b.Genre).ThenBy(b => b.Title).ToList();
//DisplayBookList(booksSortedByGenreAndTitle);

//Console.WriteLine("\nBooks sorted by Year Published(latest first) and Title");
//var booksSortedByYearAndTitle = books.OrderByDescending(b => b.PublishedYear).ThenBy(b => b.Title).ToList();
//DisplayBookList(booksSortedByYearAndTitle);

//Console.WriteLine("\nOldest and newest book - Year Published");
//var oldestBookYear = books.Select(b => b.PublishedYear).Min();
//Console.WriteLine($"Oldest Year Published: {oldestBookYear}");

//var newestBookYear = books.Select(b => b.PublishedYear).Max();
//Console.WriteLine($"Most recent Year Published: {newestBookYear}");

//Console.WriteLine("\nJ.R.R. Tolkien first book");
//var tolkienFirstBook = books.Where(b => b.Author == "J.R.R. Tolkien").OrderBy(b => b.PublishedYear).FirstOrDefault();
//Console.WriteLine(tolkienFirstBook);

//Console.WriteLine("\nBook Count for each Genre");
//var genreCount = books.GroupBy(b => b.Genre).OrderBy(g => g.Key).Select(g => new {Genre = g.Key, Count = g.Count() }).ToList();
//foreach (var gc in genreCount)
//{
//    Console.WriteLine($"{gc.Genre}:{gc.Count}");
//}

//Console.WriteLine("\nClassic Books with more than 300 pages");
//var classicBooksWithMoreThan300Pages = books.Where(b => b.IsClassic == true && b.PageCount > 300).ToList();
//DisplayBookList(classicBooksWithMoreThan300Pages);

//Console.WriteLine("\nBooks that are not classics and published after 1950");
//var booksThatAreNotClassicsAfter1950 = books.Where(b => b.IsClassic == false && b.PublishedYear > 1950).ToList();
//DisplayBookList(booksThatAreNotClassicsAfter1950);

//Console.WriteLine("\nBooks by George Allen & Unwin ordered by Page Count");
//var booksByGeorgeAndAllen = books.Where(b => b.Publisher == "George Allen & Unwin").OrderBy(b => b.PageCount).ToList();
//DisplayBookList(booksByGeorgeAndAllen);

//Console.WriteLine("\nBooks that are either classic or have more than 500 pages");
//var classicsOrMoreThan500Pages = books.Where(b => b.IsClassic == true || b.PageCount > 500).ToList();
//DisplayBookList(classicsOrMoreThan500Pages);

//Console.WriteLine("\nAverage page count of books in each genre");
//var avgPageCountEachGenre = books.GroupBy(b => b.Genre).Select(g => new
//{
//    Genre = g.Key,
//    Average = g.Average(b => b.PageCount)
//}).ToList();

//foreach (var pc in avgPageCountEachGenre)
//{
//    Console.WriteLine($"{pc.Genre}: {pc.Average}");
//}

//Console.WriteLine("\nLongest book in each genre.");
//var longestBookEachGenre = books.GroupBy(b => b.Genre).Select
//    (g => g.OrderByDescending(b => b.PageCount).First());

//foreach( var lb in longestBookEachGenre)
//{
//    Console.WriteLine($"{lb.Genre}: {lb.Title}, {lb.PageCount}");
//}
   



