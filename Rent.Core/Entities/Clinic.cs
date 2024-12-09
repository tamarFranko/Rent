using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.Entities
{
    public class Clinic
    {
        public int Id { get; set; }
        public string ClinicName { get; set; }

        public string ClinicAdress { get; set; }

        public int CostForHour { get; set; }
        public List<Turn>  turns { get; set; }

    }
}
