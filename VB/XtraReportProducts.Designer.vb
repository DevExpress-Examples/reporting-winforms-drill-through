Namespace Drill_through_example

    Partial Class XtraReportProducts

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Drill_through_example.XtraReportProducts))
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
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.categoryId = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' pageInfo1
            ' 
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(325F, 23F)
            Me.pageInfo1.StyleName = "PageInfo"
            ' 
            ' pageInfo2
            ' 
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(325F, 23F)
            Me.pageInfo2.StyleName = "PageInfo"
            Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.pageInfo2.TextFormatString = "Page {0} of {1}"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
            Me.ReportHeader.HeightF = 60F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' label1
            ' 
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.label1.Name = "label1"
            Me.label1.SizeF = New System.Drawing.SizeF(650F, 24.19433F)
            Me.label1.StyleName = "Title"
            Me.label1.Text = "Products by `[CategoryName]` Category"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 28F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' table1
            ' 
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(650F, 28F)
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 1R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StyleName = "DetailCaption1"
            Me.tableCell1.StylePriority.UseBorders = False
            Me.tableCell1.Text = "Product Name"
            Me.tableCell1.Weight = 0.25669069730318511R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StyleName = "DetailCaption1"
            Me.tableCell2.Text = "Quantity Per Unit"
            Me.tableCell2.Weight = 0.30118558443509613R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StyleName = "DetailCaption1"
            Me.tableCell3.StylePriority.UseTextAlignment = False
            Me.tableCell3.Text = "Unit Price"
            Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell3.Weight = 0.18901709923377405R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StyleName = "DetailCaption1"
            Me.tableCell4.StylePriority.UseTextAlignment = False
            Me.tableCell4.Text = "Units In Stock"
            Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell4.Weight = 0.25310666597806492R
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            ' 
            ' table2
            ' 
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table2.Name = "table2"
            Me.table2.OddStyleName = "DetailData3_Odd"
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
            Me.table2.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 11.5R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StyleName = "DetailData1"
            Me.tableCell5.StylePriority.UseBorders = False
            Me.tableCell5.Weight = 0.256690673828125R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuantityPerUnit]")})
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.StyleName = "DetailData1"
            Me.tableCell6.Weight = 0.30118556096003607R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "DetailData1"
            Me.tableCell7.StylePriority.UseTextAlignment = False
            Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell7.TextFormatString = "{0:C2}"
            Me.tableCell7.Weight = 0.189017087496244R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsInStock]")})
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "DetailData1"
            Me.tableCell8.StylePriority.UseTextAlignment = False
            Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell8.Weight = 0.2531066425030048R
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""284"" />"
            table3.Name = "Products"
            columnExpression1.Table = table3
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table3
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "SupplierID"
            columnExpression3.Table = table3
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "CategoryID"
            columnExpression4.Table = table3
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "QuantityPerUnit"
            columnExpression5.Table = table3
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "UnitPrice"
            columnExpression6.Table = table3
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "UnitsInStock"
            columnExpression7.Table = table3
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitsOnOrder"
            columnExpression8.Table = table3
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ReorderLevel"
            columnExpression9.Table = table3
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discontinued"
            columnExpression10.Table = table3
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EAN13"
            columnExpression11.Table = table3
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "CategoryName"
            table4.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""184"" />"
            table4.Name = "Categories"
            columnExpression12.Table = table4
            column12.Expression = columnExpression12
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Columns.Add(column12)
            selectQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table4
            join1.Parent = table3
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table3)
            selectQuery1.Tables.Add(table4)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New DevExpress.Drawing.DXFont("Arial", 14.25F)
            Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.Title.Name = "Title"
            Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            ' 
            ' DetailCaption1
            ' 
            Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.DetailCaption1.BorderColor = System.Drawing.Color.White
            Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailCaption1.BorderWidth = 2F
            Me.DetailCaption1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.DetailCaption1.ForeColor = System.Drawing.Color.White
            Me.DetailCaption1.Name = "DetailCaption1"
            Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData1
            ' 
            Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailData1.BorderWidth = 2F
            Me.DetailData1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.DetailData1.ForeColor = System.Drawing.Color.Black
            Me.DetailData1.Name = "DetailData1"
            Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3_Odd
            ' 
            Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((231)))))), (CInt(((CByte((231)))))), (CInt(((CByte((231)))))))
            Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailData3_Odd.BorderWidth = 1F
            Me.DetailData3_Odd.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            Me.DetailData3_Odd.Name = "DetailData3_Odd"
            Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            ' 
            ' categoryId
            ' 
            Me.categoryId.Description = "Parameter1"
            Me.categoryId.Name = "categoryId"
            Me.categoryId.Type = GetType(Integer)
            Me.categoryId.ValueInfo = "0"
            Me.categoryId.Visible = False
            ' 
            ' XtraReportProducts
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.FilterString = "[CategoryID] = ?categoryId"
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.categoryId})
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption1, Me.DetailData1, Me.DetailData3_Odd, Me.PageInfo})
            Me.Version = "23.2"
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
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

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private Title As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData1 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle

        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle

        Private categoryId As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace