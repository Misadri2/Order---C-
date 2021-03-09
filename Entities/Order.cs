using System;
using OrderStatus.Entities;


namespace OrderStatus.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public Status Status { get; set; }

        public override string ToString()
        {
            return Id
            + ", "
            + Moment
            + ", "
            + Status;
        }
    }
}