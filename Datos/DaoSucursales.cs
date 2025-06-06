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
        Sucursal sucursal = new Sucursal();


        public void ParametrosAgregar(SqlCommand sqlCommand, Sucursal sucursal) // Agregado.
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlCommand.Parameters.Add("@nombreSucursal", SqlDbType.NVarChar, 100).Value = sucursal.NombreSucursal;
            sqlCommand.Parameters.Add("@descripcionSucursal", SqlDbType.NVarChar, 100).Value = sucursal.DescripcionSucursal;
            sqlCommand.Parameters.Add("@id_ProvinciaSucursal", SqlDbType.Int).Value = sucursal.Id_ProvinciaSucursal;
            sqlCommand.Parameters.Add("@direccionSucursal", SqlDbType.NVarChar, 100).Value = sucursal.DireccionSucursal;
        }


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

        public DataTable obtenerProvincias()
        {
            string consultaSql = "select * FROM Provincia";
            DataTable tabla = ds.ObtenerTabla("Provincias", consultaSql);
            return tabla;

        }

        public Boolean agregarSucursal(Sucursal sucursal)
        {
            Boolean resultado;
            SqlCommand sqlcommand = new SqlCommand();
            ParametrosAgregar(sqlcommand, sucursal);

            string consultaSql = "insert into Sucursal(NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) VALUES(@nombreSucursal, @descripcionSucursal, @id_ProvinciaSucursal, @direccionSucursal)";
            resultado = ds.EjecutarConsulta(sqlcommand, consultaSql);
            return resultado;
        }

        public Boolean eliminarSucursal(Sucursal sucursal)
        {
            Boolean resultado;
            SqlCommand sqlCommand = new SqlCommand();
            //  ParametrosAgregar(sqlCommand, sucursal);
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", sucursal.idSucursal);
            string consultaSQL = "Delete From Sucursal Where Id_Sucursal = @Id_Sucursal";
            resultado = ds.EjecutarConsulta(sqlCommand, consultaSQL);
            return resultado;
        }
    }
}
