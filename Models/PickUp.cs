using System;
using System.ComponentModel.DataAnnotations;


namespace GscStore.Models
{
    public class PickUp
    {
        public int PickUpId { get; set; }

        public int OrderId { get; set; }

        public DateTime dateTime { get; set; }
        public string Status { get; set; }




    }

}