using System.ComponentModel.DataAnnotations;

namespace Fitness.Models
{
    public class LK_countries
    {
        [Key]
        public int countru_id { get; set; }

        public string country_name { get; set; }

        public string continent_name { get; set; }

        public virtual ICollection<Register> Register { get; set; }
    }
}
