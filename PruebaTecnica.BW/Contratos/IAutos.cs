using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.BW.Contratos
{
    public interface IAutos
    {
        List<Model.Auto> ObtenerAutos();
    }
}
