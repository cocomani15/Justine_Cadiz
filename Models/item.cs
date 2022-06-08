using System.ComponentModel.DataAnnotations;

namespace webdev.Models
{
    public class item
    {
        public int Id  { get; set; }
        [Required]
        [StringLength(50)]
         public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Age { get; set; }
        [Required]
        [StringLength(50)]
        public string Gender { get; set; }
        [Required]
        [StringLength(50)]
        public string Birthday { get; set; }
    }
}