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
            Book book = new Book();
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion
        }
    }
}
