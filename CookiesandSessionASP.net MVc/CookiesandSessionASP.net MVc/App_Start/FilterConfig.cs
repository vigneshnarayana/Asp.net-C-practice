using System.Web;
using System.Web.Mvc;

namespace CookiesandSessionASP.net_MVc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
