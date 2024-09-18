<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/280259641/23.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T915105)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for Web - How to Use the Object Data Source in Web Reporting Applications

This example includes simple projects with report components (Document Viewer and Report Designer) for ASP.NET WebForms, ASP.NET MVC, ASP.NET Core, and Blazor Server (JavaScript-based) platforms. The project demonstrates how to create an object data source, bind it to a report, and restore the object data source when Document Viewer or Report Designer loads a report from a REPX file.

The [ObjectDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.ObjectBinding.ObjectDataSource) serves as an intermediate layer between the report and the collection of data elements to which the report is bound. The advantage of `ObjectDataSource` is that it is serialized in the report definition file (REPX). Otherwise, if you bind the report to a collection of custom objects, the data source information cannot be serialized, and you cannot restore the data source when you load the report from the REPX file.

Assign an `ObjectDataSource` instance to the [DataSource](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReportBase.DataSource) property of the report. The `ObjectDataSource` instance specifies the type, constructors, methods, and properties of a custom object that creates a collection of data items. The custom object can contain a method that populates the collection of data items at runtime or retrieves data from any external data source.

The `CustomWebDocumentViewerReportResolver` service in this example implements the [IWebDocumentViewerReportResolver](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.IWebDocumentViewerReportResolver) interface. The Document Viewer calls that before loading a report specified by name. The service creates a report, assigns the data source, and passes the report to the Document Viewer.

The `CustomReportStorageWebExtension` service loads and saves a report specified by name in the Report Designer. The service is a [ReportStorageWebExtension](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension) descendant.

The `CustomObjectDataSourceConstructorFilterService` implements the [IObjectDataSourceConstructorFilterService](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Web.IObjectDataSourceConstructorFilterService) interface and filters the list of constructors available for the `ObjectDataSource` in the **Report Wizard** and **Data Source Wizard**. 

The `ObjectDataSourceWizardCustomTypeProvider` service implements the [IObjectDataSourceWizardTypeProvider](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Web.IObjectDataSourceWizardTypeProvider) interface and defines the list of data types displayed for the `ObjectDataSource` in the **Report Wizard** and **Data Source Wizard**.

This example also demonstrates how to map a report parameter to the parameter used to filter data retrieved from the data source.

## Files to Review

ASP.NET WebForms:

* [EmployeesDataSource.cs](WebForms/CS/Reporting_ObjectDS_WebForms/ObjectDataSource/EmployeesDataSource.cs) (VB: [EmployeesDataSource.vb](WebForms/VB/Reporting_ObjectDS_WebForms/ObjectDataSource/EmployeesDataSource.vb))
* [CustomWebDocumentViewerReportResolver.cs](WebForms/CS/Reporting_ObjectDS_WebForms/Services/CustomWebDocumentViewerReportResolver.cs) (VB: [CustomWebDocumentViewerReportResolver.vb](WebForms/VB/Reporting_ObjectDS_WebForms/Services/CustomWebDocumentViewerReportResolver.vb))
* [CustomReportStorageWebExtension.cs](WebForms/CS/Reporting_ObjectDS_WebForms/Services/CustomReportStorageWebExtension.cs) (VB: [CustomReportStorageWebExtension.vb](WebForms/VB/Reporting_ObjectDS_WebForms/Services/CustomReportStorageWebExtension.vb))
* [CustomObjectDataSourceConstructorFilterService.cs](WebForms/CS/Reporting_ObjectDS_WebForms/Services/CustomObjectDataSourceConstructorFilterService.cs) (VB: [CustomObjectDataSourceConstructorFilterService.vb](WebForms/VB/Reporting_ObjectDS_WebForms/Services/CustomObjectDataSourceConstructorFilterService.vb))
* [ObjectDataSourceWizardCustomTypeProvider.cs](WebForms/CS/Reporting_ObjectDS_WebForms/Services/ObjectDataSourceWizardCustomTypeProvider.cs) (VB: [ObjectDataSourceWizardCustomTypeProvider.vb](WebForms/VB/Reporting_ObjectDS_WebForms/Services/ObjectDataSourceWizardCustomTypeProvider.vb))
* [Global.asax.cs](WebForms/CS/Reporting_ObjectDS_WebForms/Global.asax.cs) (VB: [Global.asax.vb](WebForms/VB/Reporting_ObjectDS_WebForms/Global.asax.vb))

ASP.NET MVC:

* [EmployeesDataSource.cs](MVC/CS/Reporting_ObjectDS_Mvc/ObjectDataSource/EmployeesDataSource.cs) 
* [CustomWebDocumentViewerReportResolver.cs](MVC/CS/Reporting_ObjectDS_Mvc/Services/CustomWebDocumentViewerReportResolver.cs) 
* [CustomReportStorageWebExtension.cs](MVC/CS/Reporting_ObjectDS_Mvc/Services/CustomReportStorageWebExtension.cs) 
* [CustomObjectDataSourceConstructorFilterService.cs](MVC/CS/Reporting_ObjectDS_Mvc/Services/CustomObjectDataSourceConstructorFilterService.cs) 
* [ObjectDataSourceWizardCustomTypeProvider.cs](MVC/CS/Reporting_ObjectDS_Mvc/Services/ObjectDataSourceWizardCustomTypeProvider.cs) 
* [Global.asax.cs](MVC/CS/Reporting_ObjectDS_Mvc/Global.asax.cs) 

ASP.NET Core:

* [EmployeesDataSource.cs](AspNetCore/Reporting_ObjectDS_AspNetCore/DataSources/EmployeesDataSource.cs)
* [CustomWebDocumentViewerReportResolver.cs](AspNetCore/Reporting_ObjectDS_AspNetCore/Services/CustomWebDocumentViewerReportResolver.cs)
* [CustomReportStorageWebExtension.cs](AspNetCore/Reporting_ObjectDS_AspNetCore/Services/CustomReportStorageWebExtension.cs)
* [CustomObjectDataSourceConstructorFilterService.cs](AspNetCore/Reporting_ObjectDS_AspNetCore/Services/CustomObjectDataSourceConstructorFilterService.cs)
* [ObjectDataSourceWizardCustomTypeProvider.cs](AspNetCore/Reporting_ObjectDS_AspNetCore/Services/ObjectDataSourceWizardCustomTypeProvider.cs)   
* [Startup.cs](AspNetCore/Reporting_ObjectDS_AspNetCore/Startup.cs) 

Blazor:

* [EmployeesDataSource.cs](Blazor/Reporting_ObjectDS_Blazor/Data/EmployeesDataSource.cs)
* [CustomWebDocumentViewerReportResolver.cs](Blazor/Reporting_ObjectDS_Blazor/Services/CustomWebDocumentViewerReportResolver.cs)
* [CustomReportStorageWebExtension.cs](Blazor/Reporting_ObjectDS_Blazor/Services/CustomReportStorageWebExtension.cs)
* [ObjectDataSourceWizardCustomTypeProvider.cs](Blazor/Reporting_ObjectDS_Blazor/Services/ObjectDataSourceWizardCustomTypeProvider.cs)
* [Startup.cs](Blazor/Reporting_ObjectDS_Blazor/Startup.cs) 


## Documentation

* [Register Types for Object Data Source Wizard (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/401228)
* [Create the Object Data Source at Runtime (ASP.NET WebForms)](https://docs.devexpress.com/XtraReports/401900)
* [Register Types for Object Data Source Wizard (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/401229)
* [Create the Object Data Source at Runtime (ASP.NET MVC)](https://docs.devexpress.com/XtraReports/401901)
* [Register Types for Object Data Source Wizard (ASP.NET Core)](https://docs.devexpress.com/XtraReports/401230)
* [Create the Object Data Source at Runtime (ASP.NET Core)](https://docs.devexpress.com/XtraReports/401902)
* [Bind a Report to an Object Data Source in Blazor Applications](https://docs.devexpress.com/XtraReports/402070)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-object-data-source&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-object-data-source&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
