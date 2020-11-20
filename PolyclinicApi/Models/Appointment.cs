using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PolyclinicApi.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PatientId { get; set; }
        [ForeignKey("PatientId"), JsonIgnore]
        public Patient Patient { get; set; }

        [Required]
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId"), JsonIgnore]
        public Service Service { get; set; }

        [JsonIgnore]
        public Event Event { get; set; }
    }
}
