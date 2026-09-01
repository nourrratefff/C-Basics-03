namespace C_Basics_03.Answers
{
    internal class Program
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
                Console.WriteLine("Successfully calculated."
            }
        }
  
    }
}
