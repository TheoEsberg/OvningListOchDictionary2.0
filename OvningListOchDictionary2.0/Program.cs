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
            countries.Add(new Country("Denmark", "DK", "Copenhagen"));
            countries.Add(new Country("United States", "US", "Washington"));
            countries.Add(new Country("Spain", "ES", "Madrid"));
            countries.Add(new Country("Japan", "JP", "Tokyo"));
            do
            {
                string UCC = Console.ReadLine().ToUpper();
                int i = 0;

                foreach (Country country in countries)
                {
                    i++;
                    if (country.Code == UCC) {
                        Console.WriteLine("The country code {0} is the code of {1}", country.Code, country.Name);
                        break;
                    }

                    if (i == countries.Count) {
                        Console.WriteLine("The country code {0} does not match the country list", UCC);
                    }
                }

                while (true)
                {
                    Console.WriteLine("Would you like to try agian?");
                    PlayAgain = Console.ReadLine().ToUpper();
                    if (PlayAgain == "YES" || PlayAgain == "NO") { break; }
                }

            } while (PlayAgain == "YES" || PlayAgain == "YE");

        }
    }
}
