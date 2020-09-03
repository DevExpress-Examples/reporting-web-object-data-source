Imports System
Imports System.IO
Imports System.Web
Imports DevExpress.XtraReports.Web
Imports Reporting_ObjectDS_WebForms.Services

Namespace Reporting_ObjectDS_WebForms
	Public Class Global_asax
		Inherits System.Web.HttpApplication

		Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			System.Web.Routing.RouteTable.Routes.MapPageRoute("defaultRoute", "", "~/Default.aspx")
			DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions
			DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
			DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
			DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default
			DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(New CustomReportStorageWebExtension(Server.MapPath("/Reports")))

			DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterObjectDataSourceConstructorFilterService(Of CustomObjectDataSourceConstructorFilterService)()
			DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.Register(Of DevExpress.XtraReports.Web.WebDocumentViewer.IWebDocumentViewerReportResolver, CustomWebDocumentViewerReportResolver)()

			DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterObjectDataSourceWizardTypeProvider(Of ObjectDataSourceWizardCustomTypeProvider)()
			System.Net.ServicePointManager.SecurityProtocol = System.Net.ServicePointManager.SecurityProtocol Or System.Net.SecurityProtocolType.Tls12
			ASPxReportDesigner.StaticInitialize()

			DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize(AddressOf ProcessException)

			AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error
		End Sub

		Private Sub ProcessException(ex As Exception, message As String)
			Debug.WriteLine("[{0}]: Exception occurred. Message: '{1}'. Exception Details:" & ControlChars.CrLf & "{2}", Date.Now, message, ex)
		End Sub

		Private Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
			' Code that runs on application shutdown
		End Sub

		Private Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
			' Code that runs when an unhandled error occurs
		End Sub

		Private Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
			' Code that runs when a new session is started
		End Sub

		Private Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
			' Code that runs when a session ends. 
			' Note: The Session_End event is raised only when the sessionstate mode
			' is set to InProc in the Web.config file. If session mode is set to StateServer 
			' or SQLServer, the event is not raised.
		End Sub
	End Class
End Namespace
