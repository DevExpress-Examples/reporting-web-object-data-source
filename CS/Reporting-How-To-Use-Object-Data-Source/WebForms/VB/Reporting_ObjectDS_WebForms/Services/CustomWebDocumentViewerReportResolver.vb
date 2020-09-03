Option Infer On

Imports DevExpress.DataAccess.ObjectBinding
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace Reporting_ObjectDS_WebForms
	Public Class CustomWebDocumentViewerReportResolver
		Implements IWebDocumentViewerReportResolver

		Public Function Resolve(ByVal reportEntry As String) As XtraReport Implements IWebDocumentViewerReportResolver.Resolve
			If reportEntry.StartsWith("EmployeeReport") Then
				Dim rep As XtraReport = CreateReport(reportEntry)
				rep.DataSource = CreateObjectDataSource(reportEntry)
				Return rep
			End If
			Return New XtraReport()
		End Function

		Private Function CreateObjectDataSource(ByVal reportName As String) As Object
			If reportName = "EmployeeReport" Then
				'				#Region " ODS_Constructor"
				Dim dataSource As New ObjectDataSource()
				dataSource.Name = "EmployeeObjectDS"
				dataSource.DataSource = GetType(Employees.EmployeeList)
				dataSource.Constructor = ObjectConstructorInfo.Default
				dataSource.DataMember = "Items"
				Return dataSource
				'				#End Region
			Else
				If reportName.EndsWith("7") Then
					'				#Region " ODS_ConstructorWithParameter"
					Dim dataSource As New ObjectDataSource()
					dataSource.Name = "EmployeeObjectDS"
					dataSource.DataSource = GetType(Employees.EmployeeList)
					' Specify the parameter's default value.
					Dim parameter = New Parameter("noOfItems", GetType(Integer), 7)
					dataSource.Constructor = New ObjectConstructorInfo(parameter)
					dataSource.DataMember = "Items"
					Return dataSource
					'				#End Region
				Else
					If reportName.EndsWith("Parameter") Then
						'				#Region " ODS_MapReportParameter"
						Dim dataSource As New ObjectDataSource()
						dataSource.Name = "EmployeeObjectDS"
						dataSource.DataSource = GetType(Employees.EmployeeList)
						' Map data source parameter to report's parameter.
						Dim parameter = New Parameter() With {.Name = "noOfItems", .Type = GetType(DevExpress.DataAccess.Expression), .Value = New DevExpress.DataAccess.Expression("?parameterNoOfItems", GetType(Integer))}
						dataSource.Constructor = New ObjectConstructorInfo(parameter)
						dataSource.DataMember = "Items"
						Return dataSource
						'				#End Region
					Else
						'				#Region "ODS_Method"
						Dim dataSource As New ObjectDataSource()
						dataSource.Name = "EmployeeObjectDS"
						dataSource.DataSource = GetType(Employees.EmployeeList)
						Dim parameterNoOfItems = New Parameter("noOfItems", GetType(Integer), 12)
						dataSource.Parameters.Add(parameterNoOfItems)
						dataSource.DataMember = "GetData"
						dataSource.Constructor = ObjectConstructorInfo.Default
						Return dataSource
						'				#End Region
					End If
				End If
			End If
		End Function

		Private Function CreateReport(ByVal reportEntry As String) As XtraReport
			If reportEntry.Contains("Parameter") Then
				Dim report As XtraReport = New PredefinedReports.EmployeeReport()
				Dim param As New DevExpress.XtraReports.Parameters.Parameter() With {.Name = "parameterNoOfItems", .Type = GetType(Integer), .Value = 5}
				param.Description = "Number of Items"
				report.Parameters.Add(param)
				report.RequestParameters = False
				Return report
			Else
				Return New PredefinedReports.EmployeeReport()
			End If
		End Function
	End Class

End Namespace
