using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Timers;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Book book = new Book();
            //object obj = book;
            //Console.WriteLine(obj);
            #endregion
            #region Q02
            // Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book withitself), GetHashCode(), and GetType() on book.
            //Book book = new Book();
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion
            #region Q03
            //Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.int pages = "464";
            //Compile-time Error
            //int pages = 464;
            #endregion
            #region Q04
            //Q04.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide byzero", and then prints "Done" in a finally block.
            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    int result = x / y;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide byzero");
            //}
            //finally 
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            #region Q05
            //Q05.Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double num = pages;
            #endregion
            #region Q06
            //Q06.Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int num = (int)price;
            #endregion
            #region Q07
            //Q07.Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int num = Convert.ToInt32(pagesText);
            #endregion
            #region Q08
            //Q08.Given string yearText = "2023";, convert it using int.Parse().Then given string badText = "abc";,use int.TryParse() to safely try converting it, and print "Invalid number" if it fails
            //string yearText = "2023";
            //int.Parse(yearText);
            //string badText = "abc";
            //bool num = int.TryParse(badText, out int result);
            //if (num == false)
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion
            #region Q09
            //Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()to prove it's now a string.
            //int pages = 464;
            //string page = pages.ToString();
            //Console.WriteLine(pages.GetType());
            #endregion
            #region Q10
            //Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            //int copies = 100;
            //object obj = copies;
            //int num = (int)obj;
            #endregion
            #region Q11
            //Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
            //int? year = null;
            //Console.WriteLine(year);
            //year = 2023;
            //Console.WriteLine(year);
            #endregion
            #region Q12
            //Q12.Declare a string? reviewer = null;. Print whether it is null.
            //string? reviewer = null;
            //if (reviewer == null) 
            //{
            //    Console.WriteLine("true");
            //}
            #endregion
            #region Q13
            //Q12.Declare a string? reviewer = null;. Print whether it is null.
            //Book ? book = null;
            //Console.WriteLine(book?.Title);
            #endregion
            #region Q14
            //Q14.Using title from the previous question, use ?? to print "Untitled" if title is null.Then use ??= to assign title the value "Untitled" only if it's still null.
            string? title = null;
            Console.WriteLine(title ?? "Untitled");
            title ??= "Untitled";
            Console.WriteLine(title);
            #endregion

        }

    }
}
