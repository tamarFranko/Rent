using Rent.Core.Entities;
using Rent.Core.Repositories;
using Rent.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data.Repositories
{
    public class ClinicRepository : IClinicRepository
    {
        private readonly DataContext _context;

        public ClinicRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Clinic> GetAll()
        {
            return _context.Clinics;//אילוצים
        }

        public Clinic? GetClinicById(int id)
        {
            return _context.Clinics.Find(id);
        }

        public Clinic AddClinic(Clinic clinic)
        {
            _context.Clinics.Add(clinic);
            _context.SaveChanges();
            return clinic;
        }
        public Clinic? UpdateClinic(int id, Clinic clinic)
        {
            var c = _context.Clinics.Find(id);

            if (c != null)
            {
                c.ClinicName = clinic.ClinicName;
                c.ClinicAdress = clinic.ClinicAdress;
                c.CostForHour = clinic.CostForHour;
                _context.SaveChanges();
            }

            return c;
        }
        public void DeleteClinic(int id)
        {
            var c = _context.Clinics.Find(id);
            if (c != null)
            {
                _context.Clinics.Remove(c);
                _context.SaveChanges();
            }
        }
    }
}
