
namespace Produktpris_med_metoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ange produktnamn");
            string product = Console.ReadLine();
            Console.WriteLine("Ange pris per st");
            double price = GetDouble();
            Console.WriteLine("Ange antal");
            int quantity = GetInt();
            double total = CalculateTotalPrice(price, quantity);
            Console.WriteLine($"Produkten {product} med priset {price} kr/st och antal {quantity} st kostar totalt {total} kr inkl. 25% moms");

            total = CalculateTotalPrice(price, quantity, 0.12);
            Console.WriteLine($"Produkten {product} med priset {price} kr/st och antal {quantity} st kostar totalt {total} kr inkl. 12% moms");

        }
        private static double CalculateTotalPrice(double price, int quantity, double moms = 0.25)
        {
            return price * quantity * (1 + moms);
        }

        private static double GetDouble()
        {
            double decimalTal;

            while (double.TryParse(Console.ReadLine(), out decimalTal) == false)
            {
                Console.WriteLine("Du har inte angett ett heltal. Försök igen!");

            }

            return decimalTal;

        }

        private static int GetInt()
        {
            int helTal;

            while (int.TryParse(Console.ReadLine(), out helTal) == false)
            {
                Console.WriteLine("Du har inte angett ett heltal. Försök igen!");

            }

            return helTal;

        }





    }
}
