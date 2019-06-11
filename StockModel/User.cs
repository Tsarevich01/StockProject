using System.ComponentModel.DataAnnotations;

namespace StockProject
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FIO { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
