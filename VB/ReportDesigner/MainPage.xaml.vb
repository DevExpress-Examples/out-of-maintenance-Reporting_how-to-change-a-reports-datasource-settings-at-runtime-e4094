Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.ReportDesigner.Services

Namespace ReportDesigner
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub BtnDataSet1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			AssignDataSetToReport("Categories")
		End Sub

		Private Sub BtnDataSet2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			AssignDataSetToReport("Customers")
		End Sub

		Private Sub AssignDataSetToReport(ByVal dataSetName As String)
			Dim designServices = reportDesigner.Model.DesignServices
			Dim changeService = designServices.Resolve(Of IChangeService)()
			changeService.ChangeDataSource(dataSetName)
			changeService.CommitChanges()
		End Sub
	End Class
End Namespace
