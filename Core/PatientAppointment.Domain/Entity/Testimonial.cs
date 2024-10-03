using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointment.Domain.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public string Title { get; set; }
        public string HospitalReview { get; set; }
        public string PersonnelReview { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
