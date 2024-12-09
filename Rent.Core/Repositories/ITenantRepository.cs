using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.Repositories
{
    public interface ITenantRepository
    {
        public IEnumerable<Tenant> GetAll();

        public Tenant? GetById(string id);
        public Tenant AddTenant(Tenant tenant);

        public Tenant? UpdateTenant(string id, Tenant tenant);
        public void DeleteTenant(string id);
    }
}
