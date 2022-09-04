using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Book> rentableBooks = new Stack<Book>();  //we make a new stack with books ready to be rented by people
            rentableBooks.Push(new Book("The Art of War", 450, "sun tsu shows us how its done"));
            rentableBooks.Push(new Book("The 48 Laws of Power", 457, "essential rules for the new machiavellis"));
            rentableBooks.Push(new Book("numbers", 100000, "every number from 0 to 100.000"));

            Stack<Book> userRentedBooks = new Stack<Book>();  // we assume the user will rent books


        }
    }
}
