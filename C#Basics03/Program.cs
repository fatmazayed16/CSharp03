namespace C_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st Answer
            //Create a Book object and store it in a variable of type object. Print it.
            Book book = new Book();
            object obj = book;
            Console.WriteLine(obj);
            #endregion

            #region 2nd Answer
            Book book1 = new Book();
            book1.Title = "2nd Answer";
            book1.Pages = 464;
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(book1));
            Console.WriteLine(book1.GetType().Name);
            Console.WriteLine(book1.GetHashCode());
            #endregion

        }
    }
}
