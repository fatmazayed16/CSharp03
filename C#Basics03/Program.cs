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

            #region 3rd Answer
            // int pages = "464";
            int pages = 464;
            Console.WriteLine(pages);
            #endregion

            #region 4th Answer
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
                Console.WriteLine(z);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            #endregion
        }
    }
}
