using System.Web;
using System.Web.Mvc;

namespace ThomasTech.Tutorials.BookService
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
