<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/280259641/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T915105)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

ASP.NET WebForms:

* [EmployeesDataSource.cs](./CS/Reporting-How-To-Use-Object-Data-Source/WebForms/CS/Reporting_ObjectDS_WebForms/ObjectDataSource/EmployeesDataSource.cs) (VB: [EmployeesDataSource.vb](./CS/Reporting-How-To-Use-Object-Data-Source/WebForms/VB/Reporting_ObjectDS_WebForms/ObjectDataSource/EmployeesDataSource.vb))
* [CustomWebDocumentViewerReportResolver.cs](/CS/Reporting-How-To-Use-Object-Data-Source/WebForms/CS/Reporting_ObjectDS_WebForms/Services/CustomWebDocumentViewerReportResolver.cs) (VB: [CustomWebDocumentViewerReportResolver.vb](./CS/Reporting-How-To-Use-Object-Data-Source/WebForms/VB/Reporting_ObjectDS_WebForms/Services/CustomWebDocumentViewerReportResolver.vb))
* [Global.asax.cs](./CS/Reporting-How-To-Use-Object-Data-Source/WebForms/CS/Reporting_ObjectDS_WebForms/Global.asax.cs) (VB: [Global.asax.vb](./CS/Reporting-How-To-Use-Object-Data-Source/WebForms/VB/Reporting_ObjectDS_WebForms/Global.asax.vb))

ASP.NET MVC:

* [EmployeesDataSource.cs](./CS/Reporting-How-To-Use-Object-Data-Source/MVC/CS/Reporting_ObjectDS_Mvc/ObjectDataSource/EmployeesDataSource.cs) (VB: [EmployeesDataSource.vb](./CS/Reporting-How-To-Use-Object-Data-Source/MVC/VB/Reporting_ObjectDS_Mvc/ObjectDataSource/EmployeesDataSource.vb))
* [CustomWebDocumentViewerReportResolver.cs](./CS/Reporting-How-To-Use-Object-Data-Source/MVC/CS/Reporting_ObjectDS_Mvc/Services/CustomWebDocumentViewerReportResolver.cs) (VB: [CustomWebDocumentViewerReportResolver.vb](./CS/Reporting-How-To-Use-Object-Data-Source/MVC/VB/Reporting_ObjectDS_Mvc/Services/CustomWebDocumentViewerReportResolver.vb))
* [Global.asax.cs](./CS/Reporting-How-To-Use-Object-Data-Source/MVC/CS/Reporting_ObjectDS_Mvc/Global.asax.cs) (VB: [Global.asax.vb](./CS/Reporting-How-To-Use-Object-Data-Source/MVC/VB/Reporting_ObjectDS_Mvc/Global.asax.vb))

ASP.NET Core:

* [EmployeesDataSource.cs](./CS/Reporting-How-To-Use-Object-Data-Source/AspNetCore/Reporting_ObjectDS_AspNetCore/DataSources/EmployeesDataSource.cs)
* [CustomWebDocumentViewerReportResolver.cs](./CS/Reporting-How-To-Use-Object-Data-Source/AspNetCore/Reporting_ObjectDS_AspNetCore/Services/CustomWebDocumentViewerReportResolver.cs) 
* [Startup.cs](./CS/Reporting-How-To-Use-Object-Data-Source/AspNetCore/Reporting_ObjectDS_AspNetCore/Startup.cs) 

<!-- default file list end -->

# How to Use the Object Data Source in Web Reporting Applications

This project demonstrates how to create an object data source, bind it to the report and restore the object data source when the Document Viewer or Report Designer loads a report from the REPX file.

The [ObjectDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.ObjectBinding.ObjectDataSource) serves as an intermediate layer between a report and a collection of data items to which the report is bound. The **ObjectDataSource** has an advantage that it is serialized in the report definition file (REPX). If you bind a report to a collection of custom objects, the data source information cannot be serialized and you won't be able to resore a data source when a report is loaded from REPX file.

Assign the **ObjectDataSource** instance to the report's [DataSource](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReportBase.DataSource) property. The ObjectDataSource instance specifies the type, constructors, methods and properties of a custom object that generates a collection of data items. A custom object can contain a method that populates the data item collection at runtime or retrieves the data from any external data source. 

This example includes the ObjectDataSource that generates the data at runtime.

When the Document Viewer loads a report, it retrieves data from the report's data source. You can implement and register a service that creates a report and assigns a data source before the report is sent to the Document Viewer.This example includes such a service named **CustomWebDocumentViewerReportResolver** that implements the [IWebDocumentViewerReportResolver](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.IWebDocumentViewerReportResolver) interface.    

This example also demonstrates how to map a report's parameter to the data source's parameter. The user can change the report's parameter to filter the data retrieved from the data source.

## Documentation

* [Register Types for Object Data Source Wizard (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/401228)
* [Register Types for Object Data Source Wizard (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/401229)
* [Register Types for Object Data Source Wizard (ASP.NET Core)](https://docs.devexpress.com/XtraReports/401230)
* [Create the Object Data Source at Runtime (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/401900)
* [Create the Object Data Source at Runtime (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/401901)
* [Create the Object Data Source at Runtime (ASP.NET Core)](https://docs.devexpress.com/XtraReports/401902)




<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-object-data-source&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-object-data-source&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
