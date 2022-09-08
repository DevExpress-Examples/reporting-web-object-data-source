Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.IO
Imports System.Web
Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Routing

Imports DevExpress.Web.Mvc
Imports Reporting_ObjectDS_Mvc.Services

Namespace Reporting_ObjectDS_Mvc
	' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	' visit http://go.microsoft.com/?LinkId=9394801

	Public Class MvcApplication
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start()
			DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions
			DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
			DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
			DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
			DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(New CustomReportStorageWebExtension(Server.MapPath("/Reports")))

			DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterObjectDataSourceConstructorFilterService(Of CustomObjectDataSourceConstructorFilterService)()
			DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.Register(Of DevExpress.XtraReports.Web.WebDocumentViewer.IWebDocumentViewerReportResolver, CustomWebDocumentViewerReportResolver)()


			DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterObjectDataSourceWizardTypeProvider(Of ObjectDataSourceWizardCustomTypeProvider)()
System.Net.ServicePointManager.SecurityProtocol = System.Net.ServicePointManager.SecurityProtocol Or System.Net.SecurityProtocolType.Tls12
			MVCxReportDesigner.StaticInitialize()

			DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize(AddressOf ProcessException)
			AreaRegistration.RegisterAllAreas()

			GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
			RouteConfig.RegisterRoutes(RouteTable.Routes)

			ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()

			AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error
		End Sub
		Private Sub ProcessException(ex As Exception, message As String)
			Debug.WriteLine("[{0}]: Exception occurred. Message: '{1}'. Exception Details:" & ControlChars.CrLf & "{2}", Date.Now, message, ex)
		End Sub
		Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
			Dim exception As Exception = System.Web.HttpContext.Current.Server.GetLastError()
			'TODO: Handle Exception
		End Sub
	End Class
End Namespace
