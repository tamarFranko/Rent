using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.Services
{
    public interface IClinicService
    {
        public IEnumerable<Clinic> GetList();
        public Clinic? GetOneClinic(int id);

        public Clinic AddOneClinic(Clinic clinic);
        public Clinic? UpdateOneClinic(int id, Clinic clinic);
        public void RemoveClinic(int id);
    }
}
