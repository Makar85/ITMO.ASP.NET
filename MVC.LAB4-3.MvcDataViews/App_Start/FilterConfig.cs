using System.Web;
using System.Web.Mvc;

namespace MVC.LAB4_3.MvcDataViews
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
