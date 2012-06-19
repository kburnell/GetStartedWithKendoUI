using System.Web;
using System.Web.Mvc;

namespace Part3_IntroducingKendoUIForASPMVC.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}