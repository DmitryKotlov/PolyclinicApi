using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PolyclinicApi.Data;
using PolyclinicApi.Models;
using AutoMapper;
using PolyclinicApi.Dtos;

namespace PolyclinicApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegistratorController : ControllerBase
    {
        private readonly IRegistratorRepo _repository;
        private readonly IMapper _mapper;

        public RegistratorController(IRegistratorRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        //GET api/GetAppointmentById/{id}
        [HttpGet("{id}", Name = "GetAppointmentById")]
        public ActionResult<IEnumerable<AppointmentReadDto>> GetAllAppointmentsById(int id)
        {
            var appointmentItem = _repository.GetAllAppointmentsById(id);
            if (appointmentItem != null)
            {
                return Ok(_mapper.Map<IEnumerable<AppointmentReadDto>>(appointmentItem));
            }
            return NotFound();
        }


        //GET api/GetAppointmentByName/{name}
        [HttpGet("{name}", Name = "GetAppointmentByName")]
        public ActionResult<IEnumerable<AppointmentReadDto>> GetAllAppointmentsByName(string name)
        {
            var appointmentItem = _repository.GetAllAppointmentsByName(name);
            if (appointmentItem != null)
            {
                return Ok(_mapper.Map<IEnumerable<AppointmentReadDto>>(appointmentItem));
            }
            return NotFound();
        }


        //GET api/GetDate/{id}
        [HttpGet("{id}", Name = "GetDate")]
        public ActionResult<IEnumerable<EventReadDto>> GetDate(int id)
        {
            var eventItems = _repository.GetDate(id);
            if (eventItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<EventReadDto>>(eventItems));
            }
            return NotFound();
        }


        //PATCH api/UpdateEvent
        [HttpPatch]
        public ActionResult UpdateEvent(int AppointmentId, int EventId)
        {
            var appointmentId = _repository.GetAppointmentById(AppointmentId);
            var eventItem = _repository.GetEventById(EventId);
            if (eventItem == null || appointmentId == null)
            {
                return NotFound();
            }

            if (appointmentId.ServiceId != eventItem.ServiceId)
            {
                return ValidationProblem();
            }

            if (eventItem.AppointmentId != null)
            {
                return ValidationProblem();
            }

            eventItem.AppointmentId = AppointmentId;

            _repository.UpdateEvent(eventItem);

            _repository.SaveChanges();

            return NoContent();
        }
    }
}
