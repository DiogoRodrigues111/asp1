﻿using System.Web;
using System.Web.Mvc;

namespace asp_web_framewrk
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
