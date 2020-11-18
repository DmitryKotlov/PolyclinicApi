using PolyclinicApi.Models;
using Microsoft.EntityFrameworkCore;

namespace PolyclinicApi.Data
{
    public class RegistratorContext : DbContext
    {
        public RegistratorContext(DbContextOptions<RegistratorContext> opt) : base(opt)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
