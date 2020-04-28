using System;
namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var basic = new Basics();
            basic.Example();

            var books = new BookRepository().GetBooks();

            //FindAll is a method that uses a predicate which return bool value.
            var cheapbooks = books.FindAll(IsCheaperThan50Dollar);   //the code inside this method will iterate the collection and will return the elemnts which match the condition of predicate

            foreach (var book in cheapbooks)
            {
                Console.WriteLine(book.Title);
            }

            //now the same using lamdaexp:
            var cheapbk = books.FindAll(bk=>bk.Price<50);
            foreach (var book in cheapbk)
            {
                Console.WriteLine(book.Title);
            }


        }

        //predicate condition:
        static bool IsCheaperThan50Dollar(Book book)
        {
            return book.Price < 50;
        }

    }
}
