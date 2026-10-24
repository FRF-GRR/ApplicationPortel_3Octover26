using System.Web;
using System.Web.Mvc;

namespace ApplicationPortel_3Octover26
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
