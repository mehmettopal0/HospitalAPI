using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Doctor:IEntity
    {
        [Key]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Phone { get; set; } 
        public string CertificateNo { get; set; }
        public List<Patient> Patient { get; set; }
        public List<Appointment> Appointment { get; set; }


    }
}
