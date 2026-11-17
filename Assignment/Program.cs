using System.ComponentModel;
using System.Numerics;
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
            int pages = 300;
            double num = pages;
            #endregion
        }

    }
}
