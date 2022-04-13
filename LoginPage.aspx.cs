using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace EjemploWebASPNET
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            WSHttpBinding basicHttp = new WSHttpBinding();
            //Esto tiene relación con el <wsHttpBinding> de Web.config

            basicHttp.Security.Mode = SecurityMode.None;
            //Esto tiene relación con <security mode="None" /> de Web.config

            basicHttp.Name = "MetadataExchangeHttpBinding_IService1";
            //Esto tiene relación con <binding name="MetadataExchangeHttpBinding_IService1"> de Web.config

            EndpointAddress endPoint = new EndpointAddress("http://localhost:55841/Service1.svc/mex");

            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client(basicHttp, endPoint);
            //Se realiza la conexión

            //var datos = obj.ObtenerUsuarios();
            */
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client servicio = new Connection().CrearConexion();
            //Se crea la conexión

            if(servicio.VerificarAcceso(txt_Username.Text, txt_password.Text))
            {
                HttpContext.Current.Response.Redirect("DatosPage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuario Incorrecto');</script>");
            }
        }
    }
}


