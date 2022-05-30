using System.ComponentModel.DataAnnotations;

namespace CrudOperations.API.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }
        public decimal? UnitPrice { get; set; }  
    }
}
