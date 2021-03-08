using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DXWebApplication3.PredefinedReports;

namespace DXWebApplication3.Services
{
    public class CustomDrillThroughProcessor : IWebDocumentViewerDrillThroughProcessor
    {
        public XtraReport CreateReport(DrillThroughContext context)
        {
            if (context.CustomData == "#back")
                return new MainXtraReport();
            if (context.CustomData == "#Details")
                return new DetailsXtraReport();
           
            return context.Report;
        }
    }
}