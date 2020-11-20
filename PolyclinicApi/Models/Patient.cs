using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PolyclinicApi.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [JsonIgnore]
        public List<Appointment> Appointment { get; set; } = new List<Appointment>();
    }
}
