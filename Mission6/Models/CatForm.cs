using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class CatForm
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
