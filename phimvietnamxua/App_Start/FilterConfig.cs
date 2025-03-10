﻿using System.Web;
using System.Web.Mvc;
using WebMarkupMin.AspNet4.Mvc;

namespace phimvietnamxua
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MinifyHtmlAttribute());
            filters.Add(new CompressContentAttribute());
            filters.Add(new MinifyXmlAttribute());
        }
    }
}
