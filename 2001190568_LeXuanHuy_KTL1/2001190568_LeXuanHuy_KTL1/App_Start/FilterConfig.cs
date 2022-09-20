using System.Web;
using System.Web.Mvc;

namespace _2001190568_LeXuanHuy_KTL1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}