using Microsoft.AspNetCore.Mvc;
using static System.Object;
using Rent.Core.Services;
using Rent.Core.Entities;
using AutoMapper;
using Rent.Core.DTOs;
using Rent.API.Models;
using Rent.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantsController : ControllerBase
    {
        public readonly ITenantService _tenantService;
        public readonly IMapper _mapper;

        public TenantsController(ITenantService tenantService, IMapper mapper)
        {
            _tenantService = tenantService;
            _mapper = mapper;
        }


        // GET: api/<TenantsController>
        [HttpGet]
        public ActionResult Get()
        {
            var tenantDto = _mapper.Map<IEnumerable<TenantDto>>(_tenantService.GetList());
            return Ok(tenantDto);
        }

        // GET api/<TenantsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var tenant = _tenantService.GetOneTenant(id);
            if (tenant == null)
            {
                return NotFound();
            }
            var tenantDto = _mapper.Map<TenantDto>(tenant);
            return Ok(tenantDto);
        }

        // POST api/<TenantsController>
        [HttpPost]
        public ActionResult Post([FromBody] TenantPostModel t)
        {
            // if the tenant is exists return conflict
            var tenant = new Tenant { FirstName = t.FirstName, LastName = t.LastName, Id = t.Id, Phone = t.Phone, EmailAddress = t.EmailAddress };
            _tenantService.AddOneTenant(tenant);
            return Ok();
        }

        // PUT api/<TenantsController>/5
        [HttpPut("{id}")]

        public ActionResult Put(string id, [FromBody] TenantPostModel t)
        {
            var tenant = _tenantService.GetOneTenant(id);
            if (tenant == null)
            {
                return Conflict();
            }
            var tenant2 = new Tenant { FirstName = t.FirstName, LastName = t.LastName, Id = t.Id, Phone = t.Phone, EmailAddress = t.EmailAddress };
            return Ok(_tenantService.UpdateOneTenant(id, tenant2));
        }

        // DELETE api/<TenantsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var tenant = _tenantService.GetOneTenant(id);
            if (tenant == null)
            {
                return Conflict();
            }
            _tenantService.RemoveTenant(id);
            return Ok();
        }

    }
}
