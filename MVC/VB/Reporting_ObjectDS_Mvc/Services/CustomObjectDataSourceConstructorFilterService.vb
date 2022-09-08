Imports DevExpress.DataAccess.Web
Imports Reporting_ObjectDS_Mvc.Employees
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Public Class CustomObjectDataSourceConstructorFilterService
	Implements IObjectDataSourceConstructorFilterService

	Public Function Filter(ByVal dataSourceType As Type, ByVal constructors As IEnumerable(Of ConstructorInfo)) As IEnumerable(Of ConstructorInfo) Implements IObjectDataSourceConstructorFilterService.Filter
		If dataSourceType Is GetType(EmployeeList) Then
			Return constructors
		Else
			Return constructors.Where(Function(x) x.GetParameters().Length > 0)
		End If
	End Function
End Class
