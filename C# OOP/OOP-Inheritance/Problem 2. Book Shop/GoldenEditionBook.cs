using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Book_Shop
{
    class GoldenEditionBook : Book
    {
        private decimal higherPrice; // 30%

        public GoldenEditionBook(string author, string title, double price) : base(author, title, price)
        {
            
        }

        public override double Price => base.Price*1.3;
    }
}
