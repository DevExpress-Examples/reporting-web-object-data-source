Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Reporting_ObjectDS_Mvc.Employees
	<DisplayName("Employees")>
	Public Class EmployeeList
		Public Sub New()
			Items = GetData()
		End Sub
		Public Sub New(ByVal noOfItems As Integer)

			Items = GetData().GetRange(1, noOfItems)
		End Sub
		Public Property Items() As List(Of DataItem)

		Public Function GetData() As List(Of DataItem)
			Return New List(Of DataItem)() From {
				New DataItem(1, 101, "Andrew Fuller", "Dr.", "Vice President, Sales"),
				New DataItem(1, 102, "Anne Dodsworth", "Ms.", "Sales Representative"),
				New DataItem(1, 103, "Michael Suyama", "Mr.", "Sales Representative"),
				New DataItem(1, 104, "Janet Leverling", "Ms.", "Sales Representative"),
				New DataItem(1, 105, "Elliot Komaroff", "Dr.", "Sales Coordinator"),
				New DataItem(2, 201, "Nancy Davolio", "Ms.", "Sales Representative"),
				New DataItem(2, 202, "Steven Buchanan", "Mr.", "Sales Manager"),
				New DataItem(2, 203, "Laura Callahan", "Ms.", "Sales Coordinator"),
				New DataItem(3, 301, "Frédérique Citeaux", "Mr.", "Sales Coordinator"),
				New DataItem(3, 302, "Laurence Lebihan", "Mr.", "Sales Representative"),
				New DataItem(3, 303, "Elizabeth Lincoln", "Ms.", "Sales Manager"),
				New DataItem(3, 304, "Yang Wang", "Mr.", "Sales Representative"),
				New DataItem(4, 401, "Antonio Moreno", "Mr.", "Sales Representative"),
				New DataItem(4, 402, "Thomas Hardy", "Mr.", "Sales Representative"),
				New DataItem(4, 403, "Christina Berglund", "Ms.", "Sales Manager"),
				New DataItem(5, 501, "Alejandra Camino", "Ms.", "Sales Representative"),
				New DataItem(5, 502, "Matti Karttunen", "Mr.", "Sales Representative"),
				New DataItem(5, 503, "Rita Müller", "Mrs.", "Sales Representative")
			}
		End Function
	End Class
	Public Class DataItem
		Public Sub New(ByVal floor As Integer, ByVal office As Integer, ByVal personName As String, ByVal titleOfCourtesy As String, ByVal title As String)
			Me.Floor = floor
			Me.Office = office
			Me.PersonName = personName
			Me.TitleOfCourtesy = titleOfCourtesy
			Me.Title = title
		End Sub
		Public Property Floor() As Integer
		Public Property Office() As Integer
		Public Property PersonName() As String
		Public Property TitleOfCourtesy() As String
		Public Property Title() As String
	End Class
End Namespace
