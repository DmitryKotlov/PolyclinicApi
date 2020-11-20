using System.Collections.Generic;
using PolyclinicApi.Models;

namespace PolyclinicApi.Data
{
    public interface IRegistratorRepo
    {
        bool SaveChanges();

        IEnumerable<Appointment> GetAllAppointmentsById(int PatientId);
        IEnumerable<Appointment> GetAllAppointmentsByName(string PatientName);
        Appointment GetAppointmentById(int id);

        IEnumerable<Event> GetDate(int PatientId);
        Event GetEventById(int id);
        void UpdateEvent(Event Event);
    }
}
