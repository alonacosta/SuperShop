using System.ComponentModel.DataAnnotations;

namespace SuperShop.Models
{
    public class CityViewModel
    {
        public int CountryId { get; set; }

        public int CityId { get; set; }

        [Required]
        [Display(Name = "City")]
        [MaxLength(50, ErrorMessage = "The fiels {0} can contain {1} characters.")]
        public string Name { get; set; }
    }
}
