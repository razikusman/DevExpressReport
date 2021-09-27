using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication1.Controllers
{
    public class Sales
    {
        SalesReport salesReport new SalesReport();

        // Create a parameter and specify its name.
        Parameter param1 = new Parameter();
        param1.Name = "TotalID";

        // Specify other parameter properties.
        param1.Type = typeof(System.Int32);
        param1.Value = 1;
        param1.Description = "TotalID: ";
        param1.Visible = true;

        // Add the parameter to the report.
        report.Parameters.Add(param1);
        
        // Specify the report's filter string.
        report.FilterString = "[TotalID] = [Parameters.TotalID]";
        
         // Force the report creation without previously 
        // requesting the parameter value from end-users.
        report.RequestParameters = false;

        // Show the parameter's value on a Report Header band.
        XRLabel label = new XRLabel();
        label.DataBindings.Add(new XRBinding(param1, "Text", "TotalID: {0}"));
        ReportHeaderBand reportHeader = new ReportHeaderBand();
        reportHeader.Controls.Add(label);
        report.Bands.Add(reportHeader);

        // Assign the report to a ReportPrintTool,
        // to hide the Parameters panel,
        // and show the report's print preview.
        ReportPrintTool pt = new ReportPrintTool(report);
        pt.AutoShowParametersPanel = true;
        pt.ShowPreviewDialog();
    }
}