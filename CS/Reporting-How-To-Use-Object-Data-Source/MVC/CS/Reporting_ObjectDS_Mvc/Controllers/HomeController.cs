using DevExpress.DataAccess.ObjectBinding;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Reporting_ObjectDS_Mvc.Controllers
{
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Designer() {
            Models.ReportDesignerModel model = new Models.ReportDesignerModel();
            ObjectDataSource dataSource = new ObjectDataSource();
            dataSource.Name = "EmployeeObjectDS";
            dataSource.DataSource = typeof(Employees.EmployeeList);
            dataSource.Constructor = ObjectConstructorInfo.Default;
            dataSource.DataMember = "Items";
            dataSource.RebuildResultSchema();
            model.DataSources = new Dictionary<string, object>();
            model.DataSources.Add("EmployeeObjectDS", dataSource);
            return View(model);
        }

        public ActionResult Viewer() {
            return View();
        }
    }
}
