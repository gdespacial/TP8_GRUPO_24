using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GestionSucursales;
using Entidades;

namespace Vistas
{
    public partial class ListadoDeSucursales : System.Web.UI.Page
    {

        NegocioSucursales neg = new NegocioSucursales();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (!IsPostBack) 
            {            
            cargarGridview();
            }

        }

        public void cargarGridview()
        {
            DataTable sucursales = neg.getTabla();
            gvSucursales.DataSource = sucursales;
            gvSucursales.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            int idSucursal;
            if (int.TryParse(txtIdSucursal.Text, out idSucursal))
            {
                Response.Write("Filtrando ID: " + idSucursal);
                DataTable sucursalesFiltradas = neg.getTablaFiltrada(idSucursal);
                gvSucursales.DataSource = sucursalesFiltradas;
                gvSucursales.DataBind();
                limpiarCampos();
            }
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            cargarGridview();
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            txtIdSucursal.Text = "";
        }
    }
}