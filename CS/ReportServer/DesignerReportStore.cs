using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using DevExpress.XtraReports.Service.Extensions;

namespace ReportServer {
    [Export(typeof(IDesignerReportStore))]
    public class DesignerReportStore : IDesignerReportStore {
        static readonly IDictionary<string, byte[]> layouts = new ConcurrentDictionary<string, byte[]>();

        #region IDesignerReportStore Members

        public byte[] LoadLayout(string reportName) {
            byte[] layout;
            layouts.TryGetValue(reportName, out layout);
            return layout;
        }

        public void SaveLayout(string reportName, byte[] layoutData) {
            layouts[reportName] = layoutData;
        }

        #endregion
    }
}