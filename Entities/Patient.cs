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
    public class Patient:IEntity
    {
        [Key]
        public int PatientId { get; set; }
        public string IdentificationNo { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int? OldDoctorId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Appointment> Appointment { get; set; }
    }
}
