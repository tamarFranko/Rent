using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.Entities
{
    public class Tenant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Phone {  get; set; }
        public string EmailAddress { get; set; }
        public List<Turn> Turns { get; set; }

    }
}
