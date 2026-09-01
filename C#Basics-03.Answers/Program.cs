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



            //Question 5
            
            string yearText = "2023";
            int yearTextCinverted = int.Parse(yearText);


            //Question 6

            string badText = "abc";
            if (int.TryParse(badText, out int badTextConverted))
            {
                Console.WriteLine("Converted!");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            //Question 7

            int pages2 = 464;

            var pages2Converted = pages2.ToString("0.00");
            Console.WriteLine(pages2Converted.GetType());


            //Question 8


            int copies = 100;

            object objectCopies = copies;


            int newCopies = (int)objectCopies;

            Console.WriteLine(objectCopies);
            Console.WriteLine(newCopies);


            //Question 9

            int pages3 = 464;

            if(pages3 > 300)
            {
                Console.WriteLine("Long Book");

            }
            else
            {
                Console.WriteLine("Short Book");
            }
        }

    }
}
