using System;
using System.Collections.Generic;
using System.Text;

namespace StockProject
{
    public class StockComponent
    {
        public int Id { get; set; }

        public int StockId { get; set; }

        public int ComponentId { get; set; }

        public int Count { get; set; }

        public int Barcode { get; set; }

        public int Sum { get; set; }

        public int SumInNds { get; set; }

        public virtual Stock Stock { get; set; }

        public virtual Component Component { get; set; }
    }
}
