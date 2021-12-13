using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Appointment:IEntity
    {
        [Key]
        public int AppointmentId { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [ForeignKey("Patient")]
        public int? PatientId { get; set; }
        public Patient Patient { get; set; }

        public DateTime Date { get; }
        public bool IsFamilyDoctor { get; set; }
        public Prescription Prescription { get; set; }



    }
}
