using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolyclinicApi.Dtos
{
    public class AppointmentReadDto
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public int ServiceId { get; set; }
    }
}
