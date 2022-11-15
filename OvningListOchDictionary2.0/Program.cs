using System;
using System.Collections.Generic;

namespace OvningListOchDictionary2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            App();

        }

        public static void App()
        {
            string PlayAgain;
            List<Country> countries = new List<Country>();
            countries.Add(new Country("Sweden", "SE", "Stockholm"));
            countries.Add(new Country("Denmark", "DE", "Copenhagen"));
            countries.Add(new Country("United States", "US", "Washington"));
            countries.Add(new Country("Spain", "ES", "Madrid"));
            countries.Add(new Country("Japan", "JP", "Tokyo"));
            do
            {
                string UCC = Console.ReadLine();

                foreach (Country country in countries)
                {
                    if (country.Code == UCC)
                    {
                        Console.WriteLine("The country code {0} is the code of {1}", country.Code, country.Name);
                    }
                }

                Console.WriteLine("Would you like to try agian?");
                PlayAgain = Console.ReadLine().ToUpper();
            } while (PlayAgain == "YES" || PlayAgain == "YE");

        }
    }
}
