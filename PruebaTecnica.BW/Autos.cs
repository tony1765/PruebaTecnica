using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.BW
{
    public class Autos
    {
        public PruebaTecnica.BW.Contratos.IAutos autos;
        public Autos(Contratos.IAutos autos) 
        {
            this.autos = autos;
        }
        public List<Model.Auto> ObtenerAutos()
        {
            return this.autos.ObtenerAutos();
        }

    }
}
