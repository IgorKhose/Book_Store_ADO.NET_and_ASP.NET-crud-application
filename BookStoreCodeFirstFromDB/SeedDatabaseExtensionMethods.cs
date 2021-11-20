using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
namespace BookStoreCodeFirstFromDB
{
    public static class SeedDatabaseExtensionMethods
    {
        // extension method of AutoLotEntities to clear out the database tables, then seed all tables with initial data
        public static void SeedDatabase(this BookStoreContext context)
        {
            // set up database log to write to output window in VS
            context.Database.Log = (s => Debug.Write(s));

            context.Database.Delete();
            context.Database.Create();

            context.SaveChanges();

            List<Customer> customers = new List<Customer>()
            {
                new Customer { FirstName = "Bruce", LastName = "Wayne" },
                new Customer { FirstName = "Diana", LastName = "Prince" },
                new Customer { FirstName = "Clark", LastName = "Kent" },
                new Customer { FirstName = "Barry", LastName = "Allen" },
                new Customer { FirstName = "Hal", LastName = "Jordan" },
                new Customer { FirstName = "Arthur", LastName = "Curry" },
                new Customer { FirstName = "John", LastName = "Jones" },
                new Customer { FirstName = "Oliver", LastName = "Queen" },
                new Customer { FirstName = "Ray", LastName = "Palmer" },
                new Customer { FirstName = "Zatanna", LastName = "Zatara" },
                new Customer { FirstName = "John", LastName = "Constantine" }
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();

            List<Book> books = new List<Book>()
            {
                new Book { BookTitle = "Lord of the Flies", Author = "William Golding" },
                new Book { BookTitle = "Hamlet", Author = "William Shakespeare" },
                new Book { BookTitle = "Brave New World", Author = "Aldous Huxley" },
                new Book { BookTitle = "Hard to Be a God", Author = "Arkady and Boris Strugatsky" },
                new Book { BookTitle = "Norse Mythology", Author = "Neil Gaiman" },
                new Book { BookTitle = "Outpost", Author = "Dmitry Glukhovsky" },
                new Book { BookTitle = "The Road", Author = "Cormac McCarthy" },
                new Book { BookTitle = "Day of the Oprichnik", Author = "Vladimir Sorokin" },
                new Book { BookTitle = "Carrousel’s Dead-heat", Author = "Haruki Murakami" },
                new Book { BookTitle = "The Financier", Author = "Theodore Dreiser" }
            };

            context.Books.AddRange(books);
            context.SaveChanges();

            List<Order> orders = new List<Order>()
            {
                new Order { Book = books[0], Customer = customers[1]},
                new Order { Book = books[1], Customer = customers[2]},
                new Order { Book = books[2], Customer = customers[3]},
                new Order { Book = books[3], Customer = customers[4]},
                new Order { Book = books[4], Customer = customers[5]},
                new Order { Book = books[5], Customer = customers[6]},
                new Order { Book = books[6], Customer = customers[7]},
                new Order { Book = books[7], Customer = customers[8]},
                new Order { Book = books[8], Customer = customers[9]}

            };

            context.Orders.AddRange(orders);
            context.SaveChanges();

        }
    }
}
