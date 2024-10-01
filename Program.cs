namespace Valutaomvandlare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The amount of maney that you whnt to transfer in SEK: ");

            int userInputInSek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("what currency do you want to transfer your money to? ");
            Console.WriteLine("1 - EUR");
            Console.WriteLine("2 - GBP");
            Console.WriteLine("3 - JPY");
            Console.WriteLine("4 - USD");

            string selectedCurrencySomString = Console.ReadLine()!;
            int selectedcurrency = Convert.ToInt32(selectedCurrencySomString);

            double convertedAmount = 0; 

            switch (selectedcurrency) 
            {


               case 1:
                    convertedAmount = userInputInSek * 0.08;
                    Console.WriteLine($"when you select EUR they become: {convertedAmount}"); 
                    break;
                
               case 2:

                    convertedAmount = userInputInSek * 0.07;
                    Console.WriteLine($"when you select GBP they become: {convertedAmount}");
                    break;

                case 3:

                    convertedAmount = userInputInSek * 12.00;
                    Console.WriteLine($"when you select JPY they become: {convertedAmount}");
                    break;

                case 4:

                    convertedAmount = userInputInSek * 0.10;
                    Console.WriteLine($"when you select USA they become: {convertedAmount}");
                    break;

            }
        }
    }
}
