using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_2.Book_Shop
{
    class Book
    {
        private string title;
        private string author;
        private double price;
        private string regexPattern = "([0-9]+)";


        public Book(string author, string title, double price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }



        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!").InnerException;
                }
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {

                string[] splitetdAuthor = value.Split();
                Regex regex = new Regex(regexPattern);
                Match match = regex.Match(splitetdAuthor[1]);
                if (match.Success)
                {
                  throw new ArgumentException("Author not valid!");
                    
                }
                
                this.author = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Type: ").
                Append(this.GetType().Name).
                Append(Environment.NewLine).
                Append("Title: ").
                Append(this.Title).
                Append(Environment.NewLine).
                Append("Author: ").
                Append(this.Author).
                Append(Environment.NewLine).
                Append($"Price: {this.Price:0.0}").
                Append(Environment.NewLine);

            return stringBuilder.ToString();
        }
    }
}
