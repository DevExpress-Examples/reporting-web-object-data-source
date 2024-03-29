using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.UI;
using Reporting_ObjectDS_Mvc.PredefinedReports;

namespace Reporting_ObjectDS_Mvc.Services
{
    public class CustomReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension
    {
        readonly string reportDirectory;
        const string FileExtension = ".repx";
        public CustomReportStorageWebExtension(string reportDirectory) {
            if (!Directory.Exists(reportDirectory)) {
                Directory.CreateDirectory(reportDirectory);
            }
            this.reportDirectory = reportDirectory;
        }

        private bool IsWithinReportsFolder(string url, string folder) {
            var rootDirectory = new DirectoryInfo(folder);
            var fileInfo = new FileInfo(Path.Combine(folder, url));
            return fileInfo.Directory.FullName.ToLower().StartsWith(rootDirectory.FullName.ToLower());
        }

        public override bool CanSetData(string url) {
            // Determines whether or not it is possible to store a report by a given URL. 
            // For instance, make the CanSetData method return false for reports that should be read-only in your storage. 
            // This method is called only for valid URLs (i.e., if the IsValidUrl method returned true) before the SetData method is called.

            return true;
        }

        public override bool IsValidUrl(string url) {
            // Determines whether or not the URL passed to the current Report Storage is valid. 
            // For instance, implement your own logic to prohibit URLs that contain white spaces or some other special characters. 
            // This method is called before the CanSetData and GetData methods.

            return Path.GetFileName(url) == url;
        }

        public override byte[] GetData(string url) {
            // Returns report layout data stored in a Report Storage using the specified URL. 
            // This method is called only for valid URLs after the IsValidUrl method is called.
            try {
                if (Directory.EnumerateFiles(reportDirectory).Select(Path.GetFileNameWithoutExtension).Contains(url))
                {
                    return File.ReadAllBytes(Path.Combine(reportDirectory, url + FileExtension));
                }
                if (ReportsFactory.Reports.ContainsKey(url))
                {
                    using (MemoryStream ms = new MemoryStream()) {
                        ReportsFactory.Reports[url]().SaveLayoutToXml(ms);
                        return ms.ToArray();
                    }
                }
            } catch (Exception) {
                throw new FaultException(new FaultReason("Could not get report data."), new FaultCode("Server"), "GetData");
            }
            throw new FaultException(new FaultReason(string.Format("Could not find report '{0}'.", url)), new FaultCode("Server"), "GetData");
        }

        public override Dictionary<string, string> GetUrls() {
            // Returns a dictionary of the existing report URLs and display names. 
            // This method is called when running the Report Designer, 
            // before the Open Report and Save Report dialogs are shown and after a new report is saved to a storage.
            
            return Directory.GetFiles(reportDirectory, "*" + FileExtension)
                                     .Select(Path.GetFileNameWithoutExtension)
                                     .Union(ReportsFactory.Reports.Select(x => x.Key))
                                     .ToDictionary<string, string>(x => x);
        }

        public override void SetData(XtraReport report, string url) {
            // Stores the specified report to a Report Storage using the specified URL. 
            // This method is called only after the IsValidUrl and CanSetData methods are called.
            if(!IsWithinReportsFolder(url, reportDirectory))
                throw new FaultException(new FaultReason("Invalid report name."), new FaultCode("Server"), "GetData");
            report.SaveLayoutToXml(Path.Combine(reportDirectory, url + FileExtension));
        }

        public override string SetNewData(XtraReport report, string defaultUrl) {
            // Stores the specified report using a new URL. 
            // The IsValidUrl and CanSetData methods are never called before this method. 
            // You can validate and correct the specified URL directly in the SetNewData method implementation 
            // and return the resulting URL used to save a report in your storage.
            SetData(report, defaultUrl);
            return defaultUrl;
        }
    }
}
