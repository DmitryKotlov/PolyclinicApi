using System.ComponentModel.DataAnnotations;

namespace PolyclinicApi.Models
{
    public class Event
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public DataType DateTime { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        public int AppointmentId { get; set; }
    }
}
