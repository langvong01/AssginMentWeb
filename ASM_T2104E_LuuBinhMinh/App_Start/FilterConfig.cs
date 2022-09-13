using System.Web;
using System.Web.Mvc;

namespace ASM_T2104E_LuuBinhMinh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
