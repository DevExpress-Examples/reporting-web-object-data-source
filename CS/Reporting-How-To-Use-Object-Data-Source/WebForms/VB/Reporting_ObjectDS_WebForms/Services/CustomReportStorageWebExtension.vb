Imports System
Imports System.Collections.Concurrent
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.ServiceModel
Imports DevExpress.XtraReports.Web.Extensions
Imports DevExpress.XtraReports.UI
Imports Reporting_ObjectDS_WebForms.PredefinedReports

Namespace Reporting_ObjectDS_WebForms.Services
	Public Class CustomReportStorageWebExtension
		Inherits DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension

		Private ReadOnly reportDirectory As String
		Private Const FileExtension As String = ".repx"
		Public Sub New(ByVal reportDirectory As String)
			If Not Directory.Exists(reportDirectory) Then
				Directory.CreateDirectory(reportDirectory)
			End If
			Me.reportDirectory = reportDirectory
		End Sub

		Private Function IsWithinReportsFolder(ByVal url As String, ByVal folder As String) As Boolean
			Dim rootDirectory = New DirectoryInfo(folder)
			Dim fileInfo = New FileInfo(Path.Combine(folder, url))
			Return fileInfo.Directory.FullName.ToLower().StartsWith(rootDirectory.FullName.ToLower())
		End Function

		Public Overrides Function CanSetData(ByVal url As String) As Boolean
			' Determines whether or not it is possible to store a report by a given URL. 
			' For instance, make the CanSetData method return false for reports that should be read-only in your storage. 
			' This method is called only for valid URLs (i.e., if the IsValidUrl method returned true) before the SetData method is called.

			Return True
		End Function

		Public Overrides Function IsValidUrl(ByVal url As String) As Boolean
			' Determines whether or not the URL passed to the current Report Storage is valid. 
			' For instance, implement your own logic to prohibit URLs that contain white spaces or some other special characters. 
			' This method is called before the CanSetData and GetData methods.

			Return Path.GetFileName(url) = url
		End Function

		Public Overrides Function GetData(ByVal url As String) As Byte()
			' Returns report layout data stored in a Report Storage using the specified URL. 
			' This method is called only for valid URLs after the IsValidUrl method is called.
			Try
				If Directory.EnumerateFiles(reportDirectory).Select(AddressOf Path.GetFileNameWithoutExtension).Contains(url) Then
					Return File.ReadAllBytes(Path.Combine(reportDirectory, url & FileExtension))
				End If
				If ReportsFactory.Reports.ContainsKey(url) Then
					Using ms As New MemoryStream()
						ReportsFactory.Reports(url)().SaveLayoutToXml(ms)
						Return ms.ToArray()
					End Using
				End If
			Catch e1 As Exception
				Throw New FaultException(New FaultReason("Could not get report data."), New FaultCode("Server"), "GetData")
			End Try
			Throw New FaultException(New FaultReason(String.Format("Could not find report '{0}'.", url)), New FaultCode("Server"), "GetData")
		End Function

		Public Overrides Function GetUrls() As Dictionary(Of String, String)
			' Returns a dictionary of the existing report URLs and display names. 
			' This method is called when running the Report Designer, 
			' before the Open Report and Save Report dialogs are shown and after a new report is saved to a storage.

			Return Directory.GetFiles(reportDirectory, "*" & FileExtension).Select(AddressOf Path.GetFileNameWithoutExtension).Union(ReportsFactory.Reports.Select(Function(x) x.Key)).ToDictionary(Function(x) x)
		End Function

		Public Overrides Sub SetData(ByVal report As XtraReport, ByVal url As String)
			' Stores the specified report to a Report Storage using the specified URL. 
			' This method is called only after the IsValidUrl and CanSetData methods are called.
			If Not IsWithinReportsFolder(url, reportDirectory) Then
				Throw New FaultException(New FaultReason("Invalid report name."), New FaultCode("Server"), "GetData")
			End If
			report.SaveLayoutToXml(Path.Combine(reportDirectory, url & FileExtension))
		End Sub

		Public Overrides Function SetNewData(ByVal report As XtraReport, ByVal defaultUrl As String) As String
			' Stores the specified report using a new URL. 
			' The IsValidUrl and CanSetData methods are never called before this method. 
			' You can validate and correct the specified URL directly in the SetNewData method implementation 
			' and return the resulting URL used to save a report in your storage.
			SetData(report, defaultUrl)
			Return defaultUrl
		End Function
	End Class
End Namespace
