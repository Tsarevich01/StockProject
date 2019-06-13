using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.BindingModel
{
    public class ContractorBindingModel
    {
        public int Id { get; set; }
                 
        public string ContractorName { get; set; }
                 
        public int Code { get; set; }
                 
        public string UrAdres { get; set; }
                 
        public int Phone { get; set; }
                 
        public string ContractorEmail { get; set; }
    }
}
