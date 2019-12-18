using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.DAL.Entities
{
    [Table("PackageType")]
    public class PackageType
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }

    }
}
