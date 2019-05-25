using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockProject
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string PersonFIO { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [ForeignKey("PersonId")]
        public virtual List<Selling> Sellings { get; set; }
    }
}
