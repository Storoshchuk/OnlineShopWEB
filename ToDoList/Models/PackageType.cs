using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    [Table("PackageType")]
    public class PackageType
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }

    }
}
