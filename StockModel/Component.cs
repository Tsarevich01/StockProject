using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockProject
{
    public class Component
    {
        public int Id { get; set; }

        [Required]
        public string ComponentName { get; set; }

        [Required]
        public int Barcode { get; set; }

        public virtual List<ProductComponent> ProductComponents { get; set; }
        public virtual List<StockComponent> StockComponents { get; set; }        
    }
}
