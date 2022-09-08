Namespace Reporting_ObjectDS_Mvc.PredefinedReports
	Partial Public Class EmployeeReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim ObjectConstructorInfo1 As DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Title
            '
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1.0!
            Me.Title.Font = New System.Drawing.Font("Arial", 14.25!)
            Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
            Me.Title.Name = "Title"
            '
            'DetailCaption1
            '
            Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
            Me.DetailCaption1.BorderColor = System.Drawing.Color.White
            Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailCaption1.BorderWidth = 2.0!
            Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
            Me.DetailCaption1.ForeColor = System.Drawing.Color.White
            Me.DetailCaption1.Name = "DetailCaption1"
            Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
            Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'DetailData1
            '
            Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailData1.BorderWidth = 2.0!
            Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25!)
            Me.DetailData1.ForeColor = System.Drawing.Color.Black
            Me.DetailData1.Name = "DetailData1"
            Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
            Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'DetailData3_Odd
            '
            Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailData3_Odd.BorderWidth = 1.0!
            Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25!)
            Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            Me.DetailData3_Odd.Name = "DetailData3_Odd"
            Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
            Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'PageInfo
            '
            Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            '
            'TopMargin
            '
            Me.TopMargin.Name = "TopMargin"
            '
            'BottomMargin
            '
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
            Me.BottomMargin.Name = "BottomMargin"
            '
            'pageInfo1
            '
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 5.0!)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(315.0!, 23.0!)
            Me.pageInfo1.StyleName = "PageInfo"
            '
            'pageInfo2
            '
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(330.0!, 5.0!)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(315.0!, 23.0!)
            Me.pageInfo2.StyleName = "PageInfo"
            Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.pageInfo2.TextFormatString = "Page {0} of {1}"
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
            Me.ReportHeader.HeightF = 60.0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'label1
            '
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 5.0!)
            Me.label1.Name = "label1"
            Me.label1.SizeF = New System.Drawing.SizeF(640.0!, 24.19433!)
            Me.label1.StyleName = "Title"
            Me.label1.Text = "Report Title"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 28.0!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'table1
            '
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(650.0!, 28.0!)
            '
            'tableRow1
            '
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 1.0R
            '
            'tableCell1
            '
            Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StyleName = "DetailCaption1"
            Me.tableCell1.StylePriority.UseBorders = False
            Me.tableCell1.StylePriority.UseTextAlignment = False
            Me.tableCell1.Text = "Floor"
            Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell1.Weight = 0.13324595524714544R
            '
            'tableCell2
            '
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StyleName = "DetailCaption1"
            Me.tableCell2.StylePriority.UseTextAlignment = False
            Me.tableCell2.Text = "Office"
            Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell2.Weight = 0.145198728121244R
            '
            'tableCell3
            '
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StyleName = "DetailCaption1"
            Me.tableCell3.Text = "Person Name"
            Me.tableCell3.Weight = 0.27233433650090144R
            '
            'tableCell4
            '
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StyleName = "DetailCaption1"
            Me.tableCell4.Text = "Title Of Courtesy"
            Me.tableCell4.Weight = 0.33183643047626205R
            '
            'tableCell5
            '
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StyleName = "DetailCaption1"
            Me.tableCell5.Text = "Title"
            Me.tableCell5.Weight = 0.11738463181715746R
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
            Me.Detail.HeightF = 25.0!
            Me.Detail.Name = "Detail"
            '
            'table2
            '
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.table2.Name = "table2"
            Me.table2.OddStyleName = "DetailData3_Odd"
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
            Me.table2.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
            '
            'tableRow2
            '
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell6, Me.tableCell7, Me.tableCell8, Me.tableCell9, Me.tableCell10})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 11.5R
            '
            'tableCell6
            '
            Me.tableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Floor]")})
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.StyleName = "DetailData1"
            Me.tableCell6.StylePriority.UseBorders = False
            Me.tableCell6.StylePriority.UseTextAlignment = False
            Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell6.Weight = 0.13324594350961538R
            '
            'tableCell7
            '
            Me.tableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Office]")})
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "DetailData1"
            Me.tableCell7.StylePriority.UseTextAlignment = False
            Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell7.Weight = 0.14519871638371395R
            '
            'tableCell8
            '
            Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PersonName]")})
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "DetailData1"
            Me.tableCell8.Weight = 0.27233431302584132R
            '
            'tableCell9
            '
            Me.tableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TitleOfCourtesy]")})
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.StyleName = "DetailData1"
            Me.tableCell9.Weight = 0.33183640700120193R
            '
            'tableCell10
            '
            Me.tableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Title]")})
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.StyleName = "DetailData1"
            Me.tableCell10.Weight = 0.11738459660456731R
            '
            'objectDataSource1
            '
            Me.objectDataSource1.Constructor = ObjectConstructorInfo1
            Me.objectDataSource1.DataMember = "Items"
            Me.objectDataSource1.DataSource = GetType(Reporting_ObjectDS_Mvc.Employees.EmployeeList)
            Me.objectDataSource1.Name = "objectDataSource1"
            '
            'EmployeeReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDataSource1})
            Me.DataSource = Me.objectDataSource1
            Me.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption1, Me.DetailData1, Me.DetailData3_Odd, Me.PageInfo})
            Me.Version = "22.1"
            CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

#End Region

        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private label1 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private table1 As DevExpress.XtraReports.UI.XRTable
		Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private table2 As DevExpress.XtraReports.UI.XRTable
		Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
		Friend WithEvents DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
		Friend WithEvents DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
		Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
		Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
