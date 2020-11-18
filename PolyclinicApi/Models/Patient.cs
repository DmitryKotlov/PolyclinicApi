using System.ComponentModel.DataAnnotations;

namespace PolyclinicApi.Models
{
    public class Patient
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
