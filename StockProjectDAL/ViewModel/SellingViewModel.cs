using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.ViewModel
{
    public class SellingViewModel
    {
        public int Id { get; set; }

        [DisplayName("Наименование")]
        [Required]
        public string ComponentName { get; set; }

        [DisplayName("Группа")]
        [Required]
        public string ProductName { get; set; }

        [DisplayName("Единицы измерения")]
        [Required]
        public string Unit { get; set; }

        [DisplayName("Штрихкод")]
        [Required]
        public int BarCode { get; set; }

        [DisplayName("Количество")]
        [Required]
        public int Count { get; set; }

        [DisplayName("Сумма")]
        [Required]
        public int Sum { get; set; }

        [DisplayName("Сумма с НДС")]
        [Required]
        public int SumInNds { get; set; }

        [DisplayName("Цена")]
        [Required]
        public decimal Price { get; set; }
    }
}
