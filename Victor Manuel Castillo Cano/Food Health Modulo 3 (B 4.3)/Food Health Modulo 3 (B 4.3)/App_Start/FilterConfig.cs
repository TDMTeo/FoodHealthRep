using System.Web;
using System.Web.Mvc;

namespace Food_Health_Modulo_3__B_4._3_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
