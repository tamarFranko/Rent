using Rent.Core.Entities;

namespace Rent.API.Models
{
    public class TurnPostModel
    {
        public string ClinicName { get; set; }
        public TimeOnly StartHour { get; set; }
        public TimeOnly EndHour { get; set; }
        public int Day { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
        public string TenantId { get; set; }
    }
}
