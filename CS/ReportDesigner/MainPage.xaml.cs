using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.ReportDesigner.Services;

namespace ReportDesigner {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        void BtnDataSet1_Click(object sender, RoutedEventArgs e) {
            AssignDataSetToReport("Categories");
        }

        void BtnDataSet2_Click(object sender, RoutedEventArgs e) {
            AssignDataSetToReport("Customers");
        }

        void AssignDataSetToReport(string dataSetName) {
            var designServices = reportDesigner.Model.DesignServices;
            var changeService = designServices.Resolve<IChangeService>();
            changeService.ChangeDataSource(dataSetName);
            changeService.CommitChanges();
        }
    }
}
