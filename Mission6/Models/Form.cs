using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Form
    {
        [Key]
        [Required]
        public string title { get; set; }
        public string genre { get; set; }
        public int yearReleased { get; set; }
        public string rating { get; set; }
        public string edited { get; set; }
        public string lentTo { get; set; }
        public string notes { get; set; }
    }
}
