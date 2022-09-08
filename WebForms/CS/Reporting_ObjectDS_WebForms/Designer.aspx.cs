using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Reporting_ObjectDS_WebForms {
    public partial class Designer : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxReportDesigner1.OpenReport("EmployeeReport");
        }
    }
}
