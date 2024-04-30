 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DoctorService
    {
        public int DoctorId { get; set; }
        public int ServiceId { get; set; }
        public Doctor Doctor { get; set; }
        public Service Service { get; set; }
    }
}
