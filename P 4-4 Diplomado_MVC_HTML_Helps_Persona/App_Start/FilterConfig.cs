using System.Web;
using System.Web.Mvc;

namespace P_4_4_Diplomado_MVC_HTML_Helps_Persona
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
