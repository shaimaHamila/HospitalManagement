using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class PatientCreationDto
    {       
        public string? UserName { get; set; }
        public int Phone { get; set; }
        public int ServiceId { get; set; } 
    }
}
