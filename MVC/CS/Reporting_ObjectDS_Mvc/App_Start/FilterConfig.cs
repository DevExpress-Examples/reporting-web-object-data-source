using System.Web;
using System.Web.Mvc;

namespace Reporting_ObjectDS_Mvc {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
