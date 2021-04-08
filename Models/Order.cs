using System;
using System.ComponentModel.DataAnnotations;


namespace GscStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string Payment { get; set; }




    }

}