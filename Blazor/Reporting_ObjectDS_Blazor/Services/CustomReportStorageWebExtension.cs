using System;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.ClientControls;
using DevExpress.XtraReports.Parameters;

namespace Reporting_ObjectDS_Blazor
{
        public class CustomReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension
        {
            readonly string ReportDirectory;
            const string FileExtension = ".repx";
            public CustomReportStorageWebExtension(IWebHostEnvironment env)
            {
                ReportDirectory = Path.Combine(env.ContentRootPath, "Reports");
                if (!Directory.Exists(ReportDirectory))
                {
                    Directory.CreateDirectory(ReportDirectory);
                }
            }

            private bool IsWithinReportsFolder(string url, string folder)
            {
                var rootDirectory = new DirectoryInfo(folder);
                var fileInfo = new FileInfo(Path.Combine(folder, url));
                return fileInfo.Directory.FullName.ToLower().StartsWith(rootDirectory.FullName.ToLower());
            }

            public override bool CanSetData(string url)
            {
                // Determines whether it is possible to store a report by a given URL. 
                // For instance, make the CanSetData method return false for reports that should be read-only in your storage. 
                // This method is called only for valid URLs (for example, if the IsValidUrl method returns true) before the SetData method is called.

                return true;
            }

            public override bool IsValidUrl(string url)
            {
                // Determines whether the URL passed to the current Report Storage is valid. 
                // For instance, implement your own logic to prohibit URLs that contain white spaces or other special characters. 
                // This method is called before the CanSetData and GetData methods.

                return Path.GetFileName(url) == url;
            }

        public override byte[] GetData(string url)
        {
            string reportName = url.Substring(0, url.IndexOf("?") == -1 ? url.Length : url.IndexOf("?"));
            var query = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(url.Substring(url.IndexOf("?")+1));
            var parameterDictionary = query.SelectMany(x => x.Value, (col, value) => new KeyValuePair<string, string>(col.Key, value));

            bool needExtraParameter = reportName.Contains("XtraParameter");
            if (reportName.StartsWith("EmployeeReport")) reportName = "EmployeeReport";


            try
            {
                if (Directory.EnumerateFiles(ReportDirectory).
                    Select(Path.GetFileNameWithoutExtension).
                    Contains(reportName))
                {
                    string path = Path.Combine(ReportDirectory, reportName + FileExtension);
                    if (parameterDictionary.Count() == 0)
                        return File.ReadAllBytes(path);
                    else
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            XtraReport report = XtraReport.FromXmlFile(path);
                            foreach (KeyValuePair<string, string> entry in parameterDictionary)
                            {
                                if (report.Parameters[entry.Key] != null)
                                {
                                    report.Parameters[entry.Key].Value = entry.Value;
                                    report.Parameters[entry.Key].Visible = true;
                                }
                            }
                            if (needExtraParameter)
                            {
                                Parameter param =   new Parameter(){
                                    Name = "parameterNoOfItems",
                                    Type = typeof(int),
                                    Value = 5
                                };
                                param.Description = "Number of Items";
                                report.Parameters.Add(param);
                            }
                            report.RequestParameters = false;
                            report.SaveLayoutToXml(ms);
                            return ms.ToArray();
                        }
                    }               

                }
            }
            catch (Exception ex)
            {
                throw new FaultException("Could not get report data.", ex);
            }
            throw new FaultException(string.Format("Could not find report '{0}'.", url));
        }

        public override Dictionary<string, string> GetUrls()
            {
                // Returns a dictionary of the existing report URLs and display names. 
                // This method is called when running the Report Designer, 
                // before the Open Report and Save Report dialogs are shown and after a new report is saved to storage.

                return Directory.GetFiles(ReportDirectory, "*" + FileExtension)
                                         .Select(Path.GetFileNameWithoutExtension)
                                         .ToDictionary<string, string>(x => x);
            }

            public override void SetData(XtraReport report, string url)
            {
                // Stores the specified report to a Report Storage using the specified URL. 
                // This method is called only after the IsValidUrl and CanSetData methods are called.
                if (!IsWithinReportsFolder(url, ReportDirectory))
                    throw new DevExpress.XtraReports.Web.ClientControls.FaultException("Invalid report name.");
                report.SaveLayoutToXml(Path.Combine(ReportDirectory, url + FileExtension));
            }

            public override string SetNewData(XtraReport report, string defaultUrl)
            {
                // Stores the specified report using a new URL. 
                // The IsValidUrl and CanSetData methods are never called before this method. 
                // You can validate and correct the specified URL directly in the SetNewData method implementation 
                // and return the resulting URL used to save a report in your storage.
                SetData(report, defaultUrl);
                return defaultUrl;
            }
        }
    }
