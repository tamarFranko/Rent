using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rent.API.Models;
using Rent.Core.DTOs;
using Rent.Core.Entities;
using Rent.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicService _clinicService;
        private readonly IMapper _mapper;

        public ClinicsController(IClinicService clinicService, IMapper mapper)
        {
            _clinicService = clinicService;
            _mapper = mapper;
        }

        // GET: api/<ClinicsController>
        [HttpGet]
        public ActionResult Get()
        {
            var clinicDto = _mapper.Map<IEnumerable<ClinicDto>>(_clinicService.GetList());
            return Ok(clinicDto);
        }

        // GET api/<ClinicsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var clinic = _clinicService.GetOneClinic(id);
            if (clinic == null)
            {
                return NotFound();
            }
            var clinicDto = _mapper.Map<ClinicDto>(clinic);
            return Ok(clinicDto);
        }

        // POST api/<ClinicsController>
        [HttpPost]
        public ActionResult Post([FromBody] ClinicPostModel c)
        {
            // if the clinic is exists return conflict
            var clinic = new Clinic { ClinicAdress = c.ClinicAdress, ClinicName = c.ClinicName, CostForHour = c.CostForHour };
            _clinicService.AddOneClinic(clinic);
            return Ok();
        }

        // PUT api/<ClinicsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ClinicPostModel c)
        {
            var clinic = _clinicService.GetOneClinic(id);
            if (clinic == null)
            {
                return Conflict();
            }
            var clinic2 = new Clinic { ClinicAdress = c.ClinicAdress, ClinicName = c.ClinicName, CostForHour = c.CostForHour };
            return Ok(_clinicService.UpdateOneClinic(id, clinic2));
        }

        // DELETE api/<ClinicsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var clinic = _clinicService.GetOneClinic(id);
            if (clinic == null)
            {
                return Conflict();
            }
            _clinicService.RemoveClinic(id);
            return Ok();
        }
    }
}
