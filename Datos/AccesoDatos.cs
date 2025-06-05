using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    class AccesoDatos
    {
        //        @"Data Source=DESKTOP-9AUAVE3\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";
        //          @"Data Source=MOSTRADOR-PC\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True"
        string cadenaConexion = @"Data Source=DESKTOP-9AUAVE3\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";
        public AccesoDatos() { }

        private SqlConnection obtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        private SqlDataAdapter obtenerAdaptador(String consultaSQL, SqlConnection con)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSQL, con);
                return adaptador;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(String NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = obtenerConexion();
            SqlDataAdapter adp = obtenerAdaptador(Sql, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }

        public DataTable obtenerSucursalesFiltradas(SqlCommand comando)
        {
            try
            {
            SqlConnection Conexion = obtenerConexion();
            comando.Connection = Conexion;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaSucursales = new DataTable();
            adaptador.Fill(tablaSucursales);
            Conexion.Close();
            return tablaSucursales;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener sucursales filtradas", ex);
            }

        }

        public Boolean EjecutarConsulta(SqlCommand Comando, String consulta)
        {
            int FilasCambiadas;
            SqlConnection Conexion = obtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            if( FilasCambiadas > 0)
            {
                return true;
            }
            return false;
        }

    }
}
