using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporting_ObjectDS_WebForms.PredefinedReports
{
    public static class ReportsFactory
    {
        static ReportsFactory ()
        {
            Reports.Add("EmployeeReport", () => new EmployeeReport());
        }
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>();
    }
}
