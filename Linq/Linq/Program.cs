using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            /* Without Linq: 
            
            var cheapBooks = new List<Book>();
            foreach (var b in books)
            {
                if (b.Price < 10)
                    cheapBooks.Add(b);
            }*/

            //With Linq:
            //var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title);
            // var ord = cheapBooks.OrderBy(b => b.Title);

            //LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);         //Select method will turn books into String , so title and price wont be valid:

            foreach (var book in cheapBooks)
            {
                //  Console.WriteLine(book.Title+": $" +book.Price);  because of select
                Console.WriteLine(book);
            }

            //LINO Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b; // then it is Book
                                         // select b.Ttile; then it is String
                                         // select b.Price;    then it is float

            foreach (var bk in cheaperBooks)
                Console.WriteLine(bk.Title+" "+bk.Price);

        }
    }
}
