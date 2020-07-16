Imports DevExpress.DataAccess.Web
Imports System
Imports System.Collections.Generic

Namespace Reporting_ObjectDS_WebForms.Services
	Public Class ObjectDataSourceWizardCustomTypeProvider
		Implements IObjectDataSourceWizardTypeProvider

		Public Function GetAvailableTypes(ByVal context As String) As IEnumerable(Of Type) Implements IObjectDataSourceWizardTypeProvider.GetAvailableTypes
			Return {GetType(Employees.EmployeeList)}
		End Function
	End Class
End Namespace
