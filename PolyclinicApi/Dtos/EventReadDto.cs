using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PolyclinicApi.Dtos
{
    public class EventReadDto
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [JsonConverter(typeof(JsonDateConverter))]
        public DateTime DateTime { get; set; }

        public int ServiceId { get; set; }
    }
}
