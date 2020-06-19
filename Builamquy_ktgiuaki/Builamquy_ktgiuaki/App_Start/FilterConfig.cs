using System.Web;
using System.Web.Mvc;

namespace Builamquy_ktgiuaki
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
