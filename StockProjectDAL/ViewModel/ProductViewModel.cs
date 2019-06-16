using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [DisplayName("Названеие")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Цена")]
        [Required]
        public decimal Price { get; set; }
    }
}
