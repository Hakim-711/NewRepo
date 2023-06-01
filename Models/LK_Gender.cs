using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness.Models
{
    public class LK_Gender
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? description { get; set; }
        [Required]
        public int status { get; set; }
    }
}
