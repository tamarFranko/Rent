using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rent.API.Models;
using Rent.Core.DTOs;
using Rent.Core.Entities;
using Rent.Core.Services;
using Rent.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnsController : ControllerBase 
    {
        public readonly ITurnService _turnService;
        public readonly IMapper _mapper;

        public TurnsController(ITurnService turnService, IMapper mapper)
        {
            _turnService = turnService;
            _mapper = mapper;   
        }

        // GET: api/<TurnsController>
        [HttpGet]
        public ActionResult Get()
        {
            var turnDto = _mapper.Map<IEnumerable<TurnDto>>(_turnService.GetList());
            return Ok(turnDto);
        }

        // GET api/<TurnsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var turn = _turnService.GetOneTurn(id);
            if (turn == null)
            {
                return NotFound();
            }
            var tenantDto = _mapper.Map<TurnDto>(turn);
            return Ok(turn);
        }

        // POST api/<TurnsController>
        [HttpPost]
        public ActionResult Post([FromBody] TurnPostModel t)
        {
            // if the tenant is exists return conflict
            var turn = new Turn { StartHour = t.StartHour, EndHour = t.EndHour, Day = t.Day, DateStart = t.DateStart, DateEnd = t.DateEnd };
            _turnService.AddOneTurn(turn);
            return Ok();           
        }

        // PUT api/<TurnsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Turn t)
        {
            var turn = _turnService.GetOneTurn(id);
            if (turn == null)
            {
                return Conflict();
            }
            var turn2 = new Turn { StartHour = t.StartHour, EndHour = t.EndHour, Day = t.Day, DateStart = t.DateStart, DateEnd = t.DateEnd };
            return Ok(_turnService.UpdateOneTurn(id,turn2));
        }

        // DELETE api/<TurnsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var turn = _turnService.GetOneTurn(id);
            if (turn == null)
            {
                return Conflict();
            }
            _turnService.RemoveTurn(id);
            return Ok();
        }
    }
}
