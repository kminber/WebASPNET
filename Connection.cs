using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace EjemploWebASPNET
{
    public class Connection
    {
        public ServiceReference1.Service1Client CrearConexion()
        {
            WSHttpBinding basicHttp = new WSHttpBinding();
            //Esto tiene relación con el <wsHttpBinding> de Web.config

            basicHttp.Security.Mode = SecurityMode.None;
            //Esto tiene relación con <security mode="None" /> de Web.config

            basicHttp.Name = "MetadataExchangeHttpBinding_IService1";
            //Esto tiene relación con <binding name="MetadataExchangeHttpBinding_IService1"> de Web.config

            EndpointAddress endPoint = new EndpointAddress("http://localhost:55841/Service1.svc/mex");

            return new ServiceReference1.Service1Client(basicHttp, endPoint);
            //Se realiza la conexión

            //var datos = obj.ObtenerUsuarios();
        }
    }
}

