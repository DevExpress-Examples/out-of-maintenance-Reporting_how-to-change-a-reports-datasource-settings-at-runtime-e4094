<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/ReportDesigner/MainPage.xaml) (VB: [MainPage.xaml](./VB/ReportDesigner/MainPage.xaml))
* **[MainPage.xaml.cs](./CS/ReportDesigner/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/ReportDesigner/MainPage.xaml.vb))**
* [DesignerReportStore.cs](./CS/ReportServer/DesignerReportStore.cs) (VB: [DesignerReportStore.vb](./VB/ReportServer/DesignerReportStore.vb))
* [Global.asax.cs](./CS/ReportServer/Global.asax.cs) (VB: [Global.asax.vb](./VB/ReportServer/Global.asax.vb))
<!-- default file list end -->
# How to change a report's datasource settings at runtime


<p>This sample contains a report that has no datasource assigned to it and has controls with the specified data bindings.</p><p>There are two datasources available (<strong>DataSet1</strong> and <strong>DataSet2</strong>) that are registered in <strong>DataProviderRepository</strong> (that is also used for the Report Wizard).</p><p>After running the application, click the buttons at the bottom to choose a datasource (<strong>Categories</strong> or <strong>Customers</strong>) for the report.</p>

<br/>


