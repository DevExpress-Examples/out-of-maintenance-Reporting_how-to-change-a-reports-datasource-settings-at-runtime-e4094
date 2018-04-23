Imports Microsoft.VisualBasic
Imports System
Namespace ReportServer
	Partial Public Class SampleReport
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
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrPictureBox1})
			Me.Detail.HeightF = 74.66666F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo2, Me.xrPageInfo1})
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.Format = "Page {0} of {1}"
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 38.5F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 38.5F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel6})
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.BackColor = System.Drawing.Color.Transparent
			Me.xrLabel6.ForeColor = System.Drawing.Color.Black
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(12.5F, 37.5F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(633.9999F, 32.99999F)
			Me.xrLabel6.StylePriority.UseBackColor = False
			Me.xrLabel6.StylePriority.UseForeColor = False
			Me.xrLabel6.Text = "Sample Report"
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Icon_25")})
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(68.75F, 57.375F)
			Me.xrPictureBox1.StylePriority.UseBorders = False
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CompanyName")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(283.3333F, 21.83332F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(237.5F, 23F)
			Me.xrLabel1.StylePriority.UseBorders = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' SampleReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.ReportPrintOptions.DetailCountAtDesignTime = 5
			Me.Version = "12.2"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
	End Class
End Namespace
