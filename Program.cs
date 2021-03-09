using System;
using OrderStatus.Entities;

namespace OrderStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Status.PendingPayment,
            };

               Console.WriteLine(order);
        }
    }
}
