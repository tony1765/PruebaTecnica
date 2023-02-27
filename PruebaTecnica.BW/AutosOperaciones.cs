using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.BW
{
    public class AutosOperaciones : Contratos.IAutos
    {
        private DA.AutoDatos AutoDato;
        public AutosOperaciones()
        {
            AutoDato = new DA.AutoDatos(new DA.ConnectionManager());
        }

        public List<Model.Auto> ObtenerAutos()
        {
            return AutoDato.ObtenerAutos();
        }
    }
}
