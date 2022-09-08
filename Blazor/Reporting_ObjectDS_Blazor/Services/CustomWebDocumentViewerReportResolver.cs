using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Reporting_ObjectDS_Blazor.Reports;
using System.IO;

namespace Reporting_ObjectDS_Blazor
{
    public class CustomWebDocumentViewerReportResolver : IWebDocumentViewerReportResolver
    {
        readonly ReportStorageWebExtension reportStorageWebExtension;

        public CustomWebDocumentViewerReportResolver(ReportStorageWebExtension reportStorageWebExtension)
        {
            this.reportStorageWebExtension = reportStorageWebExtension;
        }
        public XtraReport Resolve(string reportEntry)
        {
            string reportName = reportEntry.Substring(0, reportEntry.IndexOf("?") == -1 ? reportEntry.Length : reportEntry.IndexOf("?"));

            var reportLayout = reportStorageWebExtension.GetData(reportEntry);
            if (reportLayout == null)
                return new XtraReport();
            using (var ms = new MemoryStream(reportLayout))
            {
                var report = XtraReport.FromXmlStream(ms);
                report.DataSource = CreateObjectDataSource(reportName);
                return report;
            }
        }

        private object CreateObjectDataSource(string reportName)
        {
            if (reportName == "EmployeeReport")
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeList);
                dataSource.Constructor = ObjectConstructorInfo.Default;
                dataSource.DataMember = "Items";
                return dataSource;
            }
            else
            if (reportName == "EmployeeReport7")
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeList);
                // Specify the parameter's default value.
                var parameter = new Parameter("noOfItems", typeof(int), 7);
                dataSource.Constructor = new ObjectConstructorInfo(parameter);
                dataSource.DataMember = "Items";
                return dataSource;
            }
            else
            if (reportName == "EmployeeReportXtraParameter")
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeList);
                // Map data source parameter to report's parameter.
                var parameter = new Parameter()
                {
                    Name = "noOfItems",
                    Type = typeof(DevExpress.DataAccess.Expression),
                    Value = new DevExpress.DataAccess.Expression("?parameterNoOfItems", typeof(int))
                };
                dataSource.Constructor = new ObjectConstructorInfo(parameter);
                dataSource.DataMember = "Items";
                return dataSource;
            }
            else
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeList);
                var parameterNoOfItems = new Parameter("noOfItems", typeof(int), 12);
                dataSource.Parameters.Add(parameterNoOfItems);
                dataSource.DataMember = "GetData";
                dataSource.Constructor = ObjectConstructorInfo.Default;
                return dataSource;
            }
        }

        //private XtraReport AddParameterToReport(XtraReport report)
        //{
        //    DevExpress.XtraReports.Parameters.Parameter param =
        //        new DevExpress.XtraReports.Parameters.Parameter()
        //        {
        //            Name = "parameterNoOfItems",
        //            Type = typeof(int),
        //            Value = 5
        //        };
        //    param.Description = "Number of Items";
        //    report.Parameters.Add(param);
        //    report.RequestParameters = false;
        //    return report;
        //}
    }
}
