using Ler.Entities;

namespace Ler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int nProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                string cui = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (cui == "i")
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, fee));
                }
                else if (cui == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}