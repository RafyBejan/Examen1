namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Introduceți numele clientului: ");
            string customerName = Console.ReadLine();

            Console.Write("Introduceți data comenzii (yyyy-mm-dd): ");
            DateTime orderDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Introduceți valoarea totală a comenzii: ");
            decimal orderTotal = decimal.Parse(Console.ReadLine());

            Console.Write("Introduceți metoda de plată (Card/Cash): ");
            string paymentMethod = Console.ReadLine();
        }
    }