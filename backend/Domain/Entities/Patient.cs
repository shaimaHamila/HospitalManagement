using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public int Phone { get; set; }

        public int ServiceId { get; set; }

        public virtual Service? Service { get; set; }
    }
}
