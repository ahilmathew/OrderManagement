using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class ReportFactory
    {
        public static Order GetReport(string reportType, string customerName, string address, string dueDate, List<Shape> orderedShapes)
        {
            Order report = null;
            if (reportType == "Invoice")
            {
                report = new InvoiceReport(customerName, address, dueDate, orderedShapes);
            }
            else if (reportType == "CuttingList")
            {
                report = new CuttingListReport(customerName, address, dueDate, orderedShapes);
            }
            else if (reportType == "Painting")
            {
                report = new PaintingReport(customerName, address, dueDate, orderedShapes);
            }
            return report;
        }
    }
}