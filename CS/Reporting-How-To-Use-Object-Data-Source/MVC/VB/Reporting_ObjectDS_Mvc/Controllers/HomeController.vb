Imports DevExpress.DataAccess.ObjectBinding
Imports System.Collections.Generic
Imports System.Web.Mvc

Namespace Reporting_ObjectDS_Mvc.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function Designer() As ActionResult
			Dim model As New Models.ReportDesignerModel()
			Dim dataSource As New ObjectDataSource()
			dataSource.Name = "EmployeeObjectDS"
			dataSource.DataSource = GetType(Employees.EmployeeList)
			dataSource.Constructor = ObjectConstructorInfo.Default
			dataSource.DataMember = "Items"
			dataSource.RebuildResultSchema()
			model.DataSources = New Dictionary(Of String, Object)()
			model.DataSources.Add("EmployeeObjectDS", dataSource)
			Return View(model)
		End Function

		Public Function Viewer() As ActionResult
			Return View()
		End Function
	End Class
End Namespace
