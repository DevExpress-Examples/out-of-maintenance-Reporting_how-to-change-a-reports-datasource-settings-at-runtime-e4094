Imports Microsoft.VisualBasic
Imports System.Collections.Concurrent
Imports System.Collections.Generic
Imports System.ComponentModel.Composition
Imports DevExpress.XtraReports.Service.Extensions

Namespace ReportServer
    <Export(GetType(IDesignerReportStore))> _
    Public Class DesignerReportStore
        Implements IDesignerReportStore
        Private Shared ReadOnly layouts As IDictionary(Of String, Byte()) = New ConcurrentDictionary(Of String, Byte())()

#Region "IDesignerReportStore Members"

        Public Function LoadLayout(ByVal reportName As String) As Byte() Implements IDesignerReportStore.LoadLayout
            Dim layout() As Byte
            layouts.TryGetValue(reportName, layout)
            Return layout
        End Function

        Public Sub SaveLayout(ByVal reportName As String, ByVal layoutData() As Byte) Implements IDesignerReportStore.SaveLayout
            layouts(reportName) = layoutData
        End Sub

#End Region
    End Class
End Namespace