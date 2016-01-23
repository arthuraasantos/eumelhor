using System.Web;
using System.Web.Mvc;

namespace EuMelhor.Api.AppStart
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
