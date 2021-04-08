using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace GscStore.Models
{
    public enum OrderStatus { Cart, Delivery, PickUp }

    public class Order
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public string Payment { get; set; }

        public OrderStatus Status { get; set; }

        public virtual ICollection<OrderItem> Items { get; set; }
    }

}