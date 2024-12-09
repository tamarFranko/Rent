using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.Services
{
    public interface ITenantService
    {
        public IEnumerable<Tenant> GetList();

        public Tenant GetOneTenant(string id);
        public Tenant AddOneTenant(Tenant tenant);

        public Tenant UpdateOneTenant(string id, Tenant tenant);
        public void RemoveTenant(string id);
    }
}
