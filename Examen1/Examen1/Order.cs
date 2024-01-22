using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen1.Order;

namespace Examen1
{
    internal class Order
    {
        public string Customer { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }

        public interface IPaymentSystem
        {
            void ProcessPayment(decimal amount);
        }
        public abstract class PaymentSystem
        {
            public abstract void ProcessPayment(decimal amount);
        }
        public abstract class  CardPayment:PaymentSystem
        {
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Plata de {amount:C} a fost efectuată cu cardul.");
            }
        }
        public class CashPayment : PaymentSystem
        {
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Plata de {amount:C} a fost efectuată cu bani cash.");
            }
        }
        public class OrderProcessor
        {
            public void FulfillOrder(Order order, IPaymentSystem paymentSystem)
            {
                Console.WriteLine($"Comanda pentru {order.Customer} din data de {order.Date.ToShortDateString()} cu valoarea totală de {order.Total:C} va fi procesată.");

                
                paymentSystem.ProcessPayment(order.Total);

                Console.WriteLine("Comanda a fost procesată cu succes!");
            }
        }
    }
}
