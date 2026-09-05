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

            #region 5th Answer
            int pages1 = 300;
            double pages2 = pages1;
            //Implicit conversion from int to double
            #endregion

            #region 6th Answer
            double price = 49.99;
            int price2 = (int)price;
            //Explicit conversion from double to int, y= 49.
            #endregion

            #region 7th Answer
            int PagesTxt = Convert.ToInt32("464");
            Console.WriteLine(PagesTxt);
            #endregion

            #region 8th Answer
            string yearText = "2023";
            int year = int.Parse(yearText);
            string badText = "abc";
            bool flag = int.TryParse(badText, out int result);
            //The TryParse method returns a boolean indicating, reasult = 0, and flag = false.
            if (!flag)
            {
                    Console.WriteLine("Invalid number");
            }
            #endregion

            #region 9th Answer
            int pages9 = 464;
            string pagesString = pages9.ToString();
            Console.WriteLine(pagesString.GetType().Name);
            #endregion

            #region 10th Answer
            int copies = 100;
            object obj10 = copies;
            Console.WriteLine(obj10);
            int copiesint = (int)obj10;
            Console.WriteLine(copiesint);
            #endregion



        }
    }
}
