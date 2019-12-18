using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.DAL.Entities
{
    [Table("ProductType")]
    public class ProductType
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }

    }
}
