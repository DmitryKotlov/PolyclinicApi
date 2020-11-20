using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using PolyclinicApi.Models;

namespace PolyclinicApi.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public int ServiceId { get; set; }
        [ForeignKey("ServiceId"), JsonIgnore]
        public Service Service { get; set; }

        public int? AppointmentId { get; set; }
        [ForeignKey("AppointmentId"), JsonIgnore]
        public virtual Appointment Appointment { get; set; }
    }
}
