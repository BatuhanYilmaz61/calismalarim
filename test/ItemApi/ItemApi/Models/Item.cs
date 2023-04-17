using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemApi.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; } = "";
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Category { get; set; } = "";
        public int price { get; set; }
    }
}
