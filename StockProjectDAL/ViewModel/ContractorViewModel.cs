using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.ViewModel
{
    public class ContractorViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        [Required]
        public string ContractorName { get; set; }

        [DisplayName("Код")]
        [Required]
        public int Code { get; set; }

        [DisplayName("Юридический адресс")]
        [Required]
        public string UrAdres { get; set; }

        [DisplayName("Контакты")]
        [Required]
        public int Phone { get; set; }

        [DisplayName("E-mail")]
        [Required]
        public string ContractorEmail { get; set; }
    }
}
