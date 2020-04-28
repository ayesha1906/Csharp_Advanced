using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title= "ADO.Net step by step", Price=5},
                new Book(){Title= "ADO.Net MVC", Price=9.99f},
                new Book(){Title= "ADO.Net MVC Web API", Price=12},
                new Book(){Title= "C# Advanced", Price=7},
                new Book(){Title= "C# Advanced", Price=9}


            };
        }
    }
}
