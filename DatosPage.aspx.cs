using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploWebASPNET
{
    public partial class DatosPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client servicio = new Connection().CrearConexion();
            //Se crea la conexión

            GridView1.DataSource = servicio.ObtenerUsuarios();
            GridView1.DataBind();
        }
    }
}

