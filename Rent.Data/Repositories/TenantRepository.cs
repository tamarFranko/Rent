using Rent.Core.Entities;
using Rent.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data.Repositories
{
    public class TenantRepository : ITenantRepository
    {
        public readonly DataContext _context;

        public TenantRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Tenant> GetAll()
        {
            return _context.Tenants;//להוסיף אילוץ מתאים
        }

        public Tenant? GetById(string id)
        {
            return _context.Tenants.Find(id);
        }

        public Tenant AddTenant(Tenant tenant)
        {
            _context.Tenants.Add(tenant);
            _context.SaveChanges();
            return tenant;
        }
        public Tenant? UpdateTenant(string id, Tenant tenant)
        {
            var t = _context.Tenants.Find(id);

            if (t != null) {
                t.FirstName = tenant.FirstName;
                t.LastName = tenant.LastName;
                t.Id = tenant.Id;
                t.Phone = tenant.Phone;
                t.EmailAddress = tenant.EmailAddress;
                _context.SaveChanges();
            }
            return t;
        }
        public void DeleteTenant(string id)
        {
            var t = _context.Tenants.Find(id);

            if (t != null) 
            { 
                _context.Tenants.Remove(t);
                _context.SaveChanges();
            }
        }
    }
}
