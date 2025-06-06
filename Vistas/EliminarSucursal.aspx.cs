using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionSucursales;

namespace Vistas
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        NegocioSucursales suc = new NegocioSucursales();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Boolean resultado = false;

            resultado = suc.eliminarSucursal(int.Parse(txtEliminarSucursal.Text));
            if (!resultado)
            {
                lblMensaje.Text = "Error al eliminar Sucursal";
                limpiarCampos();
            }
            else
            {
                lblMensaje.Text = "Sucursal eliminada";
                limpiarCampos();
            }

        }

        public void limpiarCampos()
        {
            txtEliminarSucursal.Text = "";
        }
    }
}