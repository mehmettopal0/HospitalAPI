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
    public class Prescription:IEntity
    {
        [Key]
        public int PrescriptionId { get; set; }

        [ForeignKey("Appointment")]
        public int? AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public List<PrescriptionMedicine> PrescriptionMedicines { get; set; }
        public DateTime Date { get; set; }
    }
}
