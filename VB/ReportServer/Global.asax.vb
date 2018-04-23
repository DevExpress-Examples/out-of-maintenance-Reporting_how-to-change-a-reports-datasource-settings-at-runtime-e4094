Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.Data
Imports ReportServer.DataSet1TableAdapters
Imports ReportServer.DataSet2TableAdapters

Namespace ReportServer
	Public Class [Global]
		Inherits System.Web.HttpApplication
		Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			Dim dataSet1 = New DataSet1()
			Using categoriesAdapter = New CategoriesTableAdapter()
				categoriesAdapter.Fill(dataSet1.Categories)
				Dim categoriesProvider = New ObjectDataProvider(dataSet1)
				DataProviderRepository.Current.Register("Categories", "Categories", categoriesProvider)
			End Using

			Dim dataSet2 = New DataSet2()
			Using customersAdapter = New CustomersTableAdapter()
				customersAdapter.Fill(dataSet2.Customers)
				Dim customersProvider = New ObjectDataProvider(dataSet2)
				DataProviderRepository.Current.Register("Customers", "Customers", customersProvider)
			End Using
		End Sub

		Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace