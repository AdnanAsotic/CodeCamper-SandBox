using Newtonsoft.Json.Serialization;
using System.Web.Http;


namespace CodeCamper.Web.App_Start
{
    public class GlobalConfig
    {
        public static void CustomizeConfig(HttpConfiguration config)
        {
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            
            //// TODO: add validation filter for JSON
        }
    }
}