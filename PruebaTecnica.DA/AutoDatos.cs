using PruebaTecnica.DA.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Model;
using System.Data;
using Dapper;

namespace PruebaTecnica.DA
{
    public class AutoDatos
    {
        private IConnection conexion;
        public AutoDatos(IConnection conexion)
        {
            this.conexion = conexion;
        }
        public List<Model.Auto> ObtenerAutos()
        {
            IEnumerable<Auto> resultadoEnumerable;
            using (IDbConnection connection = this.conexion.GetConnection())
            {
                resultadoEnumerable = connection.Query<Auto,
                                    Model.Marca,
                                    Model.Auto>(
                "usp_ConsultaAutos",
                (a, b) =>
                {
                    a.Marca = (Model.Marca)b;
                    return a;
                },
                splitOn: "IdAuto,IdMarca",
                commandType: CommandType.StoredProcedure);
            }
            
            return resultadoEnumerable.ToList();
            
        }
    }
}
