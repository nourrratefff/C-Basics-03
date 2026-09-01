namespace C_Basics_03.Answers
{
    internal class Book
    {
        static void Main(string[] args)
        {





            //Question 1


            try
            {
                int divisor = 0;
                int result = 10 / divisor;
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error occured, Cannot proceed. {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Successfully calculated.");
            }


            //Question 2

            int pages = 300;
            double convertedValue = Convert.ToDouble(pages);


            //Question 3

            double price = 49.99;
            int priceConverted = (int)price;


            //Question 4
            
            string pagesText = "464";
            int pagesTextConverted = Convert.ToInt32(pagesText);
        
            
        }

    }
}
