﻿using System.Web;
using System.Web.Mvc;

namespace mvcWithoutEntity_FrameWork
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
