using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormularioWebPrg3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMensaje.Text = "Hola Mundo - Es la primera vez que se ha cargado la página";

                // Inicializar contador de recargas en ViewState si es la primera carga
                ViewState["Recargas"] = 0;
            }
            else
            {
                lblMensaje.Text = "Esta página ya ha sido visitada";

                // Incrementar el contador de recargas en ViewState
                ViewState["Recargas"] = (int)ViewState["Recargas"] + 1;
            }

            // Mostrar el contador de usuarios (almacenado en Application)
            lblContadorUsuarios.Text = "Cantidad de usuarios que accedieron a la app: " + Application["UserCount"].ToString();

            // Mostrar el contador de recargas usando ViewState
            lblContadorRecargas.Text = "Veces que has recargado la página: " + ViewState["Recargas"].ToString();
        }

        protected void btnRecargar_Click(object sender, EventArgs e)
        {
            // Este evento solo recarga la página
            Response.Redirect(Request.RawUrl); // Redirige a la misma URL para forzar la recarga


        }
    }
}