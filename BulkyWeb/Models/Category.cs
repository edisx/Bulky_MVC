using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category name")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Normaliai ivesk")]
        [DisplayName("Display order")]
        public int DisplayOrder { get; set; }

    }
}
