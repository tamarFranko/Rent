using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.DTOs
{
    public class TurnDto
    {
        public int Id { get; set; }
        public ClinicDto Clinic { get; set; }
        public TimeOnly StartHour { get; set; }
        public TimeOnly EndHour { get; set; }
        public int Day { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
        public TenantDto Tenant { get; set; }
    }
}
