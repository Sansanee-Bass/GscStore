using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GscStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Picture { get; set; }


        public int Quantity { get; set; }

    }

}