using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
   public class DaoSucursales
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaSucursales()
        {
            string consultaSql = "Select S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, P.DescripcionProvincia As Provincia, S.DireccionSucursal From Sucursal S Inner Join Provincia P on S.Id_ProvinciaSucursal = P.Id_Provincia";
            DataTable tabla = ds.ObtenerTabla("Sucursal", consultaSql);
            return tabla;
        }

        public DataTable getTablaSucursalesFiltrada(int idSucursal)
        {
            string consultaSQL = "Select S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, P.DescripcionProvincia As Provincia, S.DireccionSucursal From Sucursal S Inner Join Provincia P on S.Id_ProvinciaSucursal = P.Id_Provincia Where S.Id_Sucursal = @Id_Sucursal";
            SqlCommand comando = new SqlCommand(consultaSQL);
            comando.Parameters.AddWithValue("@Id_Sucursal", idSucursal);
            DataTable sucursalesFiltradas = ds.obtenerSucursalesFiltradas(comando);
            return sucursalesFiltradas;
        }
    }
}
