using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.Dto
{
    public class PatientDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Phone { get; set; }
        public int ServiceId { get; set; }
    }
}
