using System.Web;
using System.Web.Mvc;

namespace EndaMcGoldrick_s00146427
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
