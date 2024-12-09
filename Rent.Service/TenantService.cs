using Rent.Core.Entities;
using Rent.Core.Repositories;
using Rent.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Service
{
    public class TenantService : ITenantService
    {
        private readonly ITenantRepository _TenantRepository;

        public TenantService(ITenantRepository TenantRepository)
        {
            _TenantRepository = TenantRepository;
        }

        public IEnumerable<Tenant> GetList()
        {
            return _TenantRepository.GetAll();
        }
        public Tenant? GetOneTenant(string id)
        {
            return _TenantRepository.GetById(id);
        }
        public Tenant AddOneTenant(Tenant tenant)
        {
            return _TenantRepository.AddTenant(tenant);
        }

        public Tenant? UpdateOneTenant(string id, Tenant tenant)
        {
            return _TenantRepository.UpdateTenant(id, tenant);
        }
        public void RemoveTenant(string id)
        {
            _TenantRepository.DeleteTenant(id);
        }
    }
}
