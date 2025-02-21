using System.ComponentModel.DataAnnotations;

//Make the model for categories
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
