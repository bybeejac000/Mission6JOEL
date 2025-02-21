using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models
{   //make the variable for the form
    public class Form
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CatForm")]
        public int CategoryId { get; set; }
        public CatForm CatForm { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string? Director{ get; set; }
        public string? Rating { get; set; }
        public int Edited { get; set; }
        public string? LentTo{ get; set; }
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}
