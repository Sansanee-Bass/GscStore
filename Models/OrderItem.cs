using System;
using System.ComponentModel.DataAnnotations;


namespace GscStore.Models
{

    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public virtual Order Order { get; set; }
    }

}