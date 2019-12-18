using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int ProductId{ get; set; }
        public Product Product { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int Amount{ get; set; }
        public int TotalPrice { get; set; }
        public int PayCheckId { get; set; }
    }
}
