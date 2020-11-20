using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PolyclinicApi.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [JsonIgnore]
        public List<Appointment> Appointment { get; set; } = new List<Appointment>();

        [JsonIgnore]
        public List<Event> Event { get; set; } = new List<Event>();
    }
}
