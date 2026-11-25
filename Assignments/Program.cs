using System.Diagnostics;
using System.Linq.Expressions;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q01
            Book book = new Book();
            Object obj = book;
            Console.WriteLine(obj);

            //Q02
            Console.WriteLine("ToString >>", book.ToString());
            Console.WriteLine("Equals >>", book.Equals(book));
            Console.WriteLine("GetHashCode >>", book.GetHashCode());
            Console.WriteLine("GetType >>", book.GetType());

            //Q03
            //its compile time error  >trying to assign string into integer 
            //int pages = 464;

            //Q04
            try
            {
                int x = 10, y = 0;
                Console.WriteLine(x / y);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            //Q05
            int Pages = 300;
            double dPages = Pages;

            //Q06
            double price = 49.99;
            int iPrice = (int)price;
            Console.WriteLine(iPrice);

            //Q07
            string pagesText = "464";
            int ipagesText = Convert.ToInt16(pagesText);
            Console.WriteLine(ipagesText + 5);

            //Q08
            string yearText = "2023", badText = "abc";
            Console.WriteLine(int.Parse(yearText));
            Console.WriteLine(int.TryParse(badText, out int parsedValue) ? "parsedValue" : "Invalid number");

            //Q09
            int pages = 464;
            string sPages = pages.ToString();
            Console.WriteLine(sPages);
            Console.WriteLine(sPages.GetType());

            //Q10
            int copies = 100;
            //boxing
            Object cObj = copies;
            //unboxing
            int z = (int)cObj;
            Console.WriteLine(cObj);
            Console.WriteLine(z);







        }
    }


    class Book
    {
        public string? Title;
        public int Pages;

    }



}
