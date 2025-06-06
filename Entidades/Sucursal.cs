using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
         private int _idSucursal;
        private string _NombreSucursal;
        private string _DescripcionSucursal;
        private string _URL_Imagen_Sucursal;
        private string _DireccionSucursal;
        private int _Id_ProvinciaSucursal; // Agregado.
    


        public Sucursal(){}
        public Sucursal(string NombreSucursal)
        {
            _NombreSucursal = NombreSucursal;
        }

        public Sucursal(int idSucursal)
        {
            _idSucursal = idSucursal;
        }
        public Sucursal(int idSucursal, string NombreSucursal, string DescripcionSucursal, string DireccionSucursal)
        {
            _idSucursal = idSucursal;
            _NombreSucursal = NombreSucursal;
            _DescripcionSucursal = DescripcionSucursal;
            _URL_Imagen_Sucursal = DireccionSucursal;
        }

        public Sucursal(string NombreSucursal, string DescripcionSucursal, int IdProvinciaSucursal,string DireccionSucursal)
        {
            _NombreSucursal = NombreSucursal;
            _DescripcionSucursal = DescripcionSucursal;
            _Id_ProvinciaSucursal = IdProvinciaSucursal;
            _DireccionSucursal = DireccionSucursal;
        }

        public Sucursal(int idSucursal, string NombreSucursal ,string DescripcionSucursal, string URL_Imagen_Sucursal,int Id_ProvinciaSucursal)
        {
            _idSucursal = idSucursal;
            _NombreSucursal = NombreSucursal;
            _DescripcionSucursal = DescripcionSucursal;
            _URL_Imagen_Sucursal = URL_Imagen_Sucursal;
            _Id_ProvinciaSucursal = Id_ProvinciaSucursal; 
        }

        public int idSucursal
        {
            get {return _idSucursal;}
            set { _idSucursal = value;}
        }   

        public string NombreSucursal
        {
            get { return _NombreSucursal; }
            set { _NombreSucursal = value;}
        }

        public string DescripcionSucursal
        {
            get {return _DescripcionSucursal;}
            set {_DescripcionSucursal = value;}
        }

        public string DireccionSucursal
        {
            get { return _DireccionSucursal; }
            set { _DireccionSucursal = value; }
        }

        public string URL_Imagen_Sucursal
        {
            get {return _URL_Imagen_Sucursal;}
            set {_URL_Imagen_Sucursal = value;}
        }

        public int Id_ProvinciaSucursal
        {
            get { return _Id_ProvinciaSucursal; }
            set { _Id_ProvinciaSucursal = value; }
        }
    }
}
