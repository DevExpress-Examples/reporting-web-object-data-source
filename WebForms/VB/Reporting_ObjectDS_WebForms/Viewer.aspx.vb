Imports System

Namespace Reporting_ObjectDS_WebForms
	Partial Public Class Viewer
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxWebDocumentViewer1.OpenReport("EmployeeReportParameter")
		End Sub
	End Class
End Namespace
