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


            List<Country> countries = new List<Country>();
            countries.Add(new Country("Sweden", "SE", "Stockholm"));
            countries.Add(new Country("Denmark", "DK", "Copenhagen"));
            countries.Add(new Country("United States", "US", "Washington"));
            countries.Add(new Country("Spain", "ES", "Madrid"));
            countries.Add(new Country("Japan", "JP", "Tokyo"));

            string UCC = Console.ReadLine().ToUpper();

            int i = 0;
            foreach (Country country in countries) {
                i++;
                if (country.Code == UCC) {
                    Console.WriteLine("The country code {0} is the code of {1}", country.Code, country.Name);
                    return;
                }

                if (i == countries.Count) {
                    Console.WriteLine("The country code was not in the list!");
                }
            }
        }
    }
}
