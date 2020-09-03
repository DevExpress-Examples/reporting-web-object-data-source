using System;

namespace Reporting_ObjectDS_WebForms
{
    public partial class Viewer : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxWebDocumentViewer1.OpenReport("EmployeeReportParameter");
        }
    }
}
