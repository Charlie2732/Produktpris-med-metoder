
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
