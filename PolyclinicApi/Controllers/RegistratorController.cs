using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolyclinicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistratorController : ControllerBase
    {

        ////GET api/commands/{id}
        //[HttpGet("{id}", Name = "GetCommandById")]
        //public ActionResult<CommandReadDto> GetAppointmentById(int id)
        //{
        //    var commandItem = _repository.GetCommandById(id);
        //    if (commandItem != null)
        //    {
        //        return Ok(_mapper.Map<CommandReadDto>(commandItem));
        //    }
        //    return NotFound();
        //}

        ////GET api/commands/{name}
        //[HttpGet("{id}", Name = "GetCommandById")]
        //public ActionResult<CommandReadDto> GetAppointmentByName(string name)
        //{
        //    var commandItem = _repository.GetCommandById(id);
        //    if (commandItem != null)
        //    {
        //        return Ok(_mapper.Map<CommandReadDto>(commandItem));
        //    }
        //    return NotFound();
        //}
    }
}
