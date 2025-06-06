using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;

namespace GestionSucursales
{
    public class NegocioSucursales
    {
       
        public DataTable getTabla()
        {
            DaoSucursales dao = new DaoSucursales(); 
            return dao.getTablaSucursales();
        }

        public DataTable getTablaFiltrada(int idSucursal)
        {
            DaoSucursales dao = new DaoSucursales();
            return dao.getTablaSucursalesFiltrada(idSucursal);
        }

        public DataTable obtenerProvincias()
        {
            DaoSucursales dao = new DaoSucursales();

            return  dao.obtenerProvincias();
        }
        public Boolean agregarSucursal(string nombre, string descripcion, int provincia, string direccion)
        {
            DaoSucursales dao = new DaoSucursales();
            Sucursal sucursal = new Sucursal(nombre, descripcion, provincia, direccion);

            return dao.agregarSucursal(sucursal);
        }

        public Boolean eliminarSucursal(int idSucursal)
        {
            DaoSucursales dao = new DaoSucursales();
            Sucursal sucursal = new Sucursal(idSucursal);
            return dao.eliminarSucursal(sucursal);
        }

    }
}
