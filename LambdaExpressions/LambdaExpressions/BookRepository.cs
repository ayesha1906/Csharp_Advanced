using System.Collections.Generic;

namespace LambdaExpressions
{

    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "title 1", Price = 50},
                new Book() {Title = "title 2", Price = 30},
                new Book() {Title = "title 3", Price = 10},

            };
        }
    }
}
