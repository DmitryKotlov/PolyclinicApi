using System.ComponentModel.DataAnnotations;

namespace PolyclinicApi.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public int ServiceId { get; set; }
    }
}
