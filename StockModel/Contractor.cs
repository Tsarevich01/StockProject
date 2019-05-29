using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockProject
{
    public class Contractor
    {
        public int Id { get; set; }

        [Required]
        public string ContractorName { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        public string UrAdres { get; set; }

        [Required]
        public int Tel { get; set; }

        [Required]
        public string ContractorEmail { get; set; }
    }
}
