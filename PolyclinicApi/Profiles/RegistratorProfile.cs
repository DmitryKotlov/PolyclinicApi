using AutoMapper;
using PolyclinicApi.Dtos;
using PolyclinicApi.Models;

namespace PolyclinicApi.Profiles
{
    public class RegistratorProfile : Profile
    {
        public RegistratorProfile()
        {
            //Source -> Target
            CreateMap<Appointment, AppointmentReadDto>();
            CreateMap<Event, EventReadDto>();
        }
    }
}
