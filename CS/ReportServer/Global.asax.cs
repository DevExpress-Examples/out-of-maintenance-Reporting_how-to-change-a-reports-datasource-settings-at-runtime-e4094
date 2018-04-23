using System;
using DevExpress.XtraReports.Data;
using ReportServer.DataSet1TableAdapters;
using ReportServer.DataSet2TableAdapters;

namespace ReportServer {
    public class Global : System.Web.HttpApplication {
        protected void Application_Start(object sender, EventArgs e) {
            var dataSet1 = new DataSet1();
            using(var categoriesAdapter = new CategoriesTableAdapter()) {
                categoriesAdapter.Fill(dataSet1.Categories);
                var categoriesProvider = new ObjectDataProvider(dataSet1);
                DataProviderRepository.Current.Register("Categories", "Categories", categoriesProvider);
            }

            var dataSet2 = new DataSet2();
            using(var customersAdapter = new CustomersTableAdapter()) {
                customersAdapter.Fill(dataSet2.Customers);
                var customersProvider = new ObjectDataProvider(dataSet2);
                DataProviderRepository.Current.Register("Customers", "Customers", customersProvider);
            }
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}