using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.DAL.Entities
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        //public int Image { get; set; }
        //[Required]
        public string ProductTypeId { get; set; }
        public int PackageTypeId { get; set; }

    }
}