using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.DA.Contratos
{
    public interface IConnection
    {
        IDbConnection GetConnection();
    }
}
