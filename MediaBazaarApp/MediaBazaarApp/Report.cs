using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mw = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Data.SqlClient;

namespace MediaBazaarApp
{
    class Report
    {
        private ConnectSQL cnn;
        private Email email;
        private DeliveryCollection dc;
        private LocationCollection lc;

        public Report(ConnectSQL cnn, DeliveryCollection dc, Email email, LocationCollection lc, string store)
        {
            this.email = email;
            this.cnn = cnn;
            this.dc = dc;
            this.lc = lc;
            lc.GetLocationData(store);
            InvoiceReport();
        }

        private void InvoiceReport()
        {
            //creating new Microsoft Word application and using InvoiceTemplate as template
            object fileName = @"C:\Users\Noah\media-bazaar-group-7\MediaBazaarApp\Resourses\OrderInvoiceTemplate.Docx";
            mw.Application wordApp = new mw.Application();
            mw.Document ReportTemplate = null;
            object missing = Missing.Value;
            object readOnly = false;
            object isVisualbe = false;
            wordApp.Visible = false;

            ReportTemplate = wordApp.Documents.Open(ref fileName,
                ref missing, ref readOnly, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);
            ReportTemplate.Activate();

            try
            {
                //finding and replacing text with data
                FindAndReplace(wordApp, "<address>", lc.LocationData().Address);
                FindAndReplace(wordApp, "<phone>", "+" + lc.LocationData().Tel.ToString()); ;
                FindAndReplace(wordApp, "<email>", lc.LocationData().Email);
                FindAndReplace(wordApp, "<website>", lc.LocationData().Email);
                FindAndReplace(wordApp, "<reportNumber>", dc.GetDeliveryInfo().OrderID);
                FindAndReplace(wordApp, "<personIC>", dc.GetDeliveryInfo().Name);
                FindAndReplace(wordApp, "<deliveryAddress>", lc.LocationData().Address);
                FindAndReplace(wordApp, "<totalPrice>", dc.GetDelvieryTotal().ToString() + "EUR");
                FindAndReplace(wordApp, "<requestDate>", dc.GetDeliveryInfo().ApprovedDate);
                FindAndReplace(wordApp, "<deliveryDate>", dc.GetDeliveryInfo().DeliveryDate);
                FindAndReplace(wordApp, "<invoiceNumber>", dc.GetDeliveryInfo().OrderID);
                FindAndReplace(wordApp, "<employeeName>", dc.GetDeliveryInfo().Name);
                FindAndReplace(wordApp, "<note>", dc.GetDeliveryInfo().Note);

                //connecting to db and getting data
                using (SqlCommand cmd = new SqlCommand("SELECT Product_ID, Product_Name, Quantity FROM OrderData WHERE Order_ID = '" + dc.GetDeliveryInfo().OrderID + "'", cnn.sqlConection()))
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        FindAndReplace(wordApp, "<productID>", reader.GetString(0) + "\r\n<productID>");
                        FindAndReplace(wordApp, "<productName>", reader.GetString(1) + "\r\n<productName>");
                        FindAndReplace(wordApp, "<qty>", reader.GetInt32(2).ToString() + "\r\n<qty>");
                    }
                    cnn.Close();
                }

                FindAndReplace(wordApp, "<productID>", "--");
                FindAndReplace(wordApp, "<productName>", "--");
                FindAndReplace(wordApp, "<qty>", "--");

                //saves report as pdf
                ReportTemplate.ExportAsFixedFormat(@"C:\Users\Noah\media-bazaar-group-7\Test Data Adder\DoNotRemove\Report " + dc.GetDeliveryInfo().OrderID + ".pdf", mw.WdExportFormat.wdExportFormatPDF);
                email.AddAttachments(true, @"C:\Users\Noah\media-bazaar-group-7\Test Data Adder\DoNotRemove\Report " + dc.GetDeliveryInfo().OrderID + ".pdf");
            }
            finally
            {
                //disposing report and application
                ReportTemplate.Close(mw.WdSaveOptions.wdDoNotSaveChanges);
                wordApp.Quit();
            }
        }

        private void FindAndReplace(mw.Application wordApp, object findText, object replaceText)
        {
            //defining object references for wordApp
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            //inputing into 'find & replace' form
            wordApp.Selection.Find.Execute(ref findText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllForms, ref forward,
                ref wrap, ref format, ref replaceText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
    }
}
