using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.DA
{
    public class ConnectionManager : PruebaTecnica.DA.Contratos.IConnection
    {
        public IDbConnection GetConnection()
        {
            return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[string.Format("{0}", "Prueba")].ConnectionString);
        }
    }
}
