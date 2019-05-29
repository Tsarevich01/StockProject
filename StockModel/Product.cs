using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockProject
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ForeignKey("SnackId")]
        public virtual List<Selling> Sellings { get; set; }

        [ForeignKey("SnackId")]
        public virtual List<ProductComponent> ProductComponents { get; set; }
    }
}
