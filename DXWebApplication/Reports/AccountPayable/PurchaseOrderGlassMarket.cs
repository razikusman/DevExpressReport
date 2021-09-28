using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DXWebApplication.Reports.AccountPayable
{
    public partial class PurchaseOrder : DevExpress.XtraReports.UI.XtraReport
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void Purchase_Order_BforPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if(sender is XtraReport report)
            {
                report.Parameters["InvDocID"].Value = "38722";
            }
        }
    }
}
