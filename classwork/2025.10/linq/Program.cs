namespace linq {
    internal class Program {
        static string[] countries = ["Albania", "UK", "Andorra", "Austria", "Latvia",
                "Litva", "Lithuania", "Liechtenstein", "Spain", "Finland", "Turkey", "Poland",
                "Austria", "Latvia", "Litva", "Lithuania"];
        static void Main(string[] args) {
            //Method1();
            //Method2();
            //Method3();
            Method4();
        }

        private static void Method4() {
            List<Product> products = new();

            for (int i = 0; i < 50; ++i) {
                Thread.Sleep(5);
                products.Add(new Product {
                    Name = "Product" + (i),
                    Price = (new Random()).Next(0, 1000),
                    Manufacturer = countries[(new Random()).Next(0, countries.Length - 1)],
                    Count = (new Random()).Next(0, 10)
                });
            }

            var pr = products.FirstOrDefault(p => p.Price > 500 && p.Manufacturer.StartsWith("B"));
            Console.WriteLine($"\nFirst: {pr}");
        }

        private static void Method1() {
            //var res = from c in countries
            //          where c.StartsWith("L")
            //          select c;
            //var res = (from c in countries
            //           where c.StartsWith("L")
            //           orderby c.Length descending
            //           select c).Distinct();

            Console.WriteLine("Countries beginning with L:");

            var res = countries
                .OrderByDescending(c => c.Length)
                .Where(c => c.StartsWith("L"))
                .Distinct();

            foreach (var item in res) {
                Console.WriteLine(item);
            }

            Console.WriteLine(res.Count());
        }

        private static void Method2() {
            List<Product> products = new();

            for(int i = 0; i < 50; ++i) {
                Thread.Sleep(5);
                products.Add(new Product {
                    Name = "Product" + (i),
                    Price = (new Random()).Next(0, 1000),
                    Manufacturer = countries[(new Random()).Next(0, countries.Length - 1)],
                    Count = (new Random()).Next(0, 10)
                });
            }
            Console.WriteLine($"All products:\n{string.Join("\n", products)}");

            var res = from p in products
                      where p.Price < 500
                      orderby p.Price
                      select p;
            var res2 = products
                .Where(p => p.Price < 500)
                .OrderBy(p => p.Price)
                .Select(p => p.ToString().ToUpper());

            Console.WriteLine($"\nProducts with price less than 500:\n{string.Join("\n", res2)}");
        }

        private static void Method3() {
            List<Product> products = new();
            for (int i = 0; i < 50; ++i) {
                Thread.Sleep(5);
                products.Add(new Product {
                    Name = "Product" + (i),
                    Price = (new Random()).Next(0, 1000),
                    Manufacturer = countries[(new Random()).Next(0, countries.Length - 1)],
                    Count = (new Random()).Next(0, 10)
                });
            }

            var res = products
                .Where(p => p.Price > 800)
                .Select(p => new { p.Name, p.Price });

            Console.WriteLine($"\nProducts with price more than 800:\n{string.Join("\n", res)}");

            Console.WriteLine("\nTop five:");
            Console.WriteLine($"{string.Join("\n", res.Take(5))}");
        }
    }
}
