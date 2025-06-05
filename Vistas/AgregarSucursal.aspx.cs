using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GestionSucursales;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        NegocioSucursales suc = new NegocioSucursales();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                ddlProvinciaSucursal.DataSource = suc.obtenerProvincias(); ;
                ddlProvinciaSucursal.DataTextField = "DescripcionProvincia";
                ddlProvinciaSucursal.DataValueField = "Id_Provincia";
                ddlProvinciaSucursal.DataBind();
                ddlProvinciaSucursal.Items.Insert(0, new ListItem("Seleccione una provincia...", ""));
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean resultado = false;

            resultado = suc.agregarSucursal(txtNombreSucursal.Text, txtDescripcionSucursal.Text, int.Parse(ddlProvinciaSucursal.SelectedValue), txtDireccionSucursal.Text);
            if (!resultado)
            {
                lblMensaje.Text = "Error al agregar Sucursal";
            }
            else
            {
                lblMensaje.Text = "Sucursal agregada";
            }
           
            
        }
    }
}