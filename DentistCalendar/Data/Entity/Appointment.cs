using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Data.Entity
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime CrateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string PatientName { get; set; }
        public string PatientSurName { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
