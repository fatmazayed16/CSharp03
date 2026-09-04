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

        }
    }
}
