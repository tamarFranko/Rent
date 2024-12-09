using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.DTOs
{
    public class ClinicDto
    {
        public int Id { get; set; }
        public string ClinicName { get; set; }

        public string ClinicAdress { get; set; }

        public int CostForHour { get; set; }
        public List<TurnDto> turns { get; set; }
    }
}
