using System.Web;
using System.Web.Mvc;

namespace Ajax_Calling_for_binding_dropdown_using_SP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
