using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBindingDemonstration_1.Models
{
    public class UserAppointment
    {
        public string Name { get; set; }

        public string EmailId { get; set; }

        public string ContactNo { get; set; }

        public string AppointmentDate { get; set; }
    }
}