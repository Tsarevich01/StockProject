using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.ViewModel
{
    public class DropProductViewModel
    {
        public int Id { get; set; }

        [DisplayName("Наименование")]
        [Required]
        public string ComponentName { get; set; }

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

        [DisplayName("Цена")]
        [Required]
        public decimal Price { get; set; }

        [DisplayName("Основание")]
        [Required]
        public string OsnText { get; set; }
    }
}
