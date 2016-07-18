using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Book_Shop
{
    class Startup
    {
        static void Main(string[] args)
        {

            string author = Console.ReadLine();
            string bookTitle = Console.ReadLine();
            double bookPrice = double.Parse(Console.ReadLine());
            
            try
            {
                var book = new Book(author, bookTitle, bookPrice);
                var goldenEditionBook = new GoldenEditionBook(author, bookTitle, bookPrice);
                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae )
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
