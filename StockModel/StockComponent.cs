using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockProject
{
    public class StockComponent
    {
        public int Id { get; set; }

        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }

        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int ContractorId { get; set; }
        public virtual Contractor Contractor { get; set; }

        public int ComponentId { get; set; }
        public virtual Component Component { get; set; }

        public int Count { get; set; }
        public int Barcode { get; set; }
        public int Sum { get; set; }
        public int SumInNds { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
