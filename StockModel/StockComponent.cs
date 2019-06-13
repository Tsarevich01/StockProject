using System.ComponentModel.DataAnnotations.Schema;

namespace StockProject
{
    public class StockComponent
    {
        public int Id { get; set; }

        public int StockId { get; set; }

        public virtual Stock Stock { get; set; }

        public int UnitId { get; set; }

        public int Count { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int Barcode { get; set; }

        public int Sum { get; set; }

        public string UnitName { get; set; }

        public int SumInNds { get; set; }

        public int ComponentId { get; set; }

        public virtual Component Component { get; set; }

        public virtual Product Product { get; set; }

    }
}
