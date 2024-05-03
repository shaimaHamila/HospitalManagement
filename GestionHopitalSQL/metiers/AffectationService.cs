using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
    public class AffectationService
    {
        Medecin medecin;
        Service service;
        DateTime debut, fin;

        public AffectationService(Medecin medecin, Service service, DateTime debut, DateTime fin)
        {
            this.Medecin = medecin;
            this.Service = service;
            this.Debut = debut;
            this.Fin = fin;
        }

        public Service Service { get => service; set => service = value; }
        public DateTime Debut { get => debut; set => debut = value; }
        public DateTime Fin { get => fin; set => fin = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }

        public override bool Equals(object obj)
        {
            var service = obj as AffectationService;
            return service != null &&
                   EqualityComparer<Medecin>.Default.Equals(Medecin, service.Medecin) &&
                   EqualityComparer<Service>.Default.Equals(this.service, service.service) &&
                   debut == service.debut;
        }
    }
}
