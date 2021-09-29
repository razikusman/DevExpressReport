using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.Expressions;

namespace DXWebApplication1.Sales_Report
{
    public partial class SalesReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public SalesReport1()
        {
            InitializeComponent();
        }

        private void Sales_PrintBefore(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var cusId = "1";
            var invId = "3";

            if (sender is XtraReport report)
            {
                report.Parameters["CustomerID"].Value = cusId;
                report.Parameters["InvoiceID"].Value = invId;
            }
        }
    }
}
