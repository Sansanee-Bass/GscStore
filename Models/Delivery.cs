using System;
using System.ComponentModel.DataAnnotations;


namespace GscStore.Models
{
    public class Delivery
    {
        public int OrderId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }
        public int Postcode { get; set; }



    }

}