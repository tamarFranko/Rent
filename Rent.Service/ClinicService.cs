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
    public class ClinicService : IClinicService
    {
        private readonly IClinicRepository _ClinicRepository;

        public ClinicService(IClinicRepository clinicRepository)
        {
            _ClinicRepository = clinicRepository;
        }
        public IEnumerable<Clinic> GetList()
        {
            return _ClinicRepository.GetAll();
        }
        public Clinic? GetOneClinic(int id)
        {
            return _ClinicRepository.GetClinicById(id);
        }

        public Clinic AddOneClinic(Clinic clinic)
        {
            return _ClinicRepository.AddClinic(clinic);
        }
        public Clinic UpdateOneClinic(int id, Clinic clinic)
        {
            return _ClinicRepository.UpdateClinic(id,clinic);
        }
        public void RemoveClinic(int id)
        {
            _ClinicRepository.DeleteClinic(id);
        }
    }
}
