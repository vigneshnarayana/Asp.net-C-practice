using System.Web;
using System.Web.Mvc;

namespace Date_formate_in_textbox_in_ASP.net_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
