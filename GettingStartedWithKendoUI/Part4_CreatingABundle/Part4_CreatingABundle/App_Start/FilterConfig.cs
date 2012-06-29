using System.Web;
using System.Web.Mvc;

namespace Part4_CreatingABundle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}