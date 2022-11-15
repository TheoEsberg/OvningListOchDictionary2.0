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
            InitCountryList();
        }

        public static void InitCountryList()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country("Sweden", "SE", "Stockholm"));
            countries.Add(new Country("Denmark", "DE", "Copenhagen"));
            countries.Add(new Country("United States", "US", "Washington"));
            countries.Add(new Country("Spain", "ES", "Madrid"));
            countries.Add(new Country("Japan", "JP", "Tokyo"));
        }
    }
}
