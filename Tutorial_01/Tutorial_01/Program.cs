using System;

namespace Tutorial_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter currency name :");
            string fromCurrencyName = Console.ReadLine();

            double fromCurrencyAmount;
            Console.Write("Enter currency amount :");

            while (true)
            {
                
                if (double.TryParse(Console.ReadLine(), out fromCurrencyAmount))
                {
                    fromCurrencyAmount = Math.Round(fromCurrencyAmount, 2);
                    break;
                }
                else
                {
                    Console.Write("Please enter currency amount again :");
                }
            }
            Console.WriteLine();
            Console.Write("Enter currency name :");
            string toCurrencyName = Console.ReadLine();

            double exchangeRate;
            Console.Write("Enter exchange rate :");

            while (true)
            {

                if (double.TryParse(Console.ReadLine(), out exchangeRate))
                {
           
                    break;
                }
                else
                {
                    Console.Write("Please enter exchange rate again :");

                }
            }

            double toCurrencyAmount = exchangeRate * fromCurrencyAmount;
            toCurrencyAmount = Math.Round(toCurrencyAmount, 6);
            Console.WriteLine();
            Console.WriteLine($"Form Currency     {fromCurrencyAmount} {fromCurrencyName}");
            Console.WriteLine($"Exchange Rate     1 {fromCurrencyName} = {exchangeRate} {toCurrencyName}");
            Console.WriteLine($"To Currency       {toCurrencyAmount} {toCurrencyName}");
        }
    }
}
