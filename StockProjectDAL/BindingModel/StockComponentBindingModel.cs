using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.BindingModel
{
    public class StockComponentBindingModel
    {
        public int Id { get; set; }

        public int StockId { get; set; }

        public int ComponentId { get; set; }

        public int Count { get; set; }

        public int Barcode { get; set; }

        public int Sum { get; set; }

        public int SumInNds { get; set; }
    }
}
