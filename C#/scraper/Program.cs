using System;

namespace scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProductsScraper scraper = new ProductsScraper("http://javascript.info");
            scraper.Start();
        }
    }
}
