using Microsoft.EntityFrameworkCore;
using PolyclinicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PolyclinicApi.Data
{
    public class SqlRegistratorRepo : IRegistratorRepo
    {
        private readonly RegistratorContext _context;

        public SqlRegistratorRepo(RegistratorContext context)
        {
            _context = context;
        }

        public IEnumerable<Appointment> GetAllAppointmentsById(int PatientId)
        {
            return _context.Appointment
                .Where(a => a.Event == null)
                .Where(a => a.PatientId == PatientId)
                .ToList();
        }

        public IEnumerable<Appointment> GetAllAppointmentsByName(string PatientName)
        {
            return _context.Appointment
                .Where(a => a.Event == null)
                .Where(a => a.Patient.Name == PatientName)
                .ToList();
        }

        public Appointment GetAppointmentById(int id)
        {
            return _context.Appointment.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Event> GetDate(int PatientId)
        {
            var appointments = GetAllAppointmentsById(PatientId);
            var events = _context.Event
                .Where(e => e.AppointmentId == null)
                .ToList();

            var test = from app in appointments
                   join even in events
                   on app.ServiceId equals even.ServiceId
                   orderby even.DateTime
                   select even;
            return test;
            // 
        }

        public Event GetEventById(int id)
        {
            return _context.Event.FirstOrDefault(e => e.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateEvent(Event Event)
        {
            _context.Event.Update(Event);
        }
    }
}