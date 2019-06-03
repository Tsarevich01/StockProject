using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockProject
{
    public class Unit
    {
        public int Id { get; set; }

        [Required]
        public string UnitName { get; set; }

        [ForeignKey("UnitId")]
        public virtual List<StockComponent> StockComponents { get; set; }
    }
}
