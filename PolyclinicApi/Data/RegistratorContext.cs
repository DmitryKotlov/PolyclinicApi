using PolyclinicApi.Models;
using Microsoft.EntityFrameworkCore;

namespace PolyclinicApi.Data
{
    public class RegistratorContext : DbContext
    {
        public RegistratorContext(DbContextOptions<RegistratorContext> opt) : base(opt)
        {

        }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Event> Event { get; set; }

    }
}
