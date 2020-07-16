Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace Reporting_ObjectDS_WebForms
	Partial Public Class Designer
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxReportDesigner1.OpenReport("EmployeeReport")
		End Sub
	End Class
End Namespace
