﻿using System.Web;
using System.Web.Mvc;

namespace FW_Food_Health_Modulo2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
