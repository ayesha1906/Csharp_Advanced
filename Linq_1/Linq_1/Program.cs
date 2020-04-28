using System;
using System.Linq;


namespace Linq_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //To get a single object we use Single
           var bk= books.Single(b => b.Title == "ADO.Net MVC");
           Console.WriteLine(bk.Title);

            //now if the title wouldnt have matched then it gives an exception that is why we can use singleOrDefault: default will return null
            var default_bk = books.SingleOrDefault(b => b.Title == "AD.Net MVC");
            Console.WriteLine(default_bk==null);

            //To get first object in collection: we also have FirstOrDefault
            var book = books.First(b => b.Title == "C# Advanced");
            Console.WriteLine(book.Title+" "+book.Price);

            var first_bk = books.First();
            Console.WriteLine(first_bk.Title);

            //To get last object in collection:
            var last = books.Last(b => b.Title == "C# Advanced");
            Console.WriteLine(last.Title + " " + last.Price);

            var last_bk = books.Last();
            Console.WriteLine(last_bk.Title);

            //Skip Take
            var pagedBooks = books.Skip(2).Take(3);
            foreach (var pageB in pagedBooks)
            {
                Console.WriteLine(pageB.Title+":  $"+pageB.Price);
            }

            //Count
            var count = books.Count();
            Console.WriteLine(count);

            //Max
            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            //Min
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);

            //Sum
            var totalPrice = books.Sum(b => b.Price);
            Console.WriteLine(totalPrice);

            //average
            var avg = books.Average(b => b.Price);
            Console.WriteLine(avg);
        }
    }
}
