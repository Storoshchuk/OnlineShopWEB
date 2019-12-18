using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
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
        public int ProductTypeId { get; set; }
        public int PackageTypeId { get; set; }

    }
}