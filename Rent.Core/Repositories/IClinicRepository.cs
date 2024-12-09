using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.Repositories
{
    public interface IClinicRepository
    {
        public IEnumerable<Clinic> GetAll();
        public Clinic? GetClinicById(int id);
        public Clinic AddClinic(Clinic clinic);
        public Clinic? UpdateClinic(int id, Clinic clinic);
        public void DeleteClinic(int id);
    }
}
