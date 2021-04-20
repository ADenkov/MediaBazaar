using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mw = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Data.SqlClient;

namespace Test_Data_Adder
{
    class Report
    {
        private SqlConnection cnn = new SqlConnection("Data Source=89.157.247.62;Initial Catalog=Media Bazaar;Persist Security Info=True;User ID=admin;Password=admin");
        private Email email;
        private Random r;
        public string Address { private get; set; }
        private string HQA { get; set; }
        private string HQT { get; set; }
        private string HQE { get; set; }
        private string HQW { get; set; }

        public Report(Email email) { this.email = email; GetAllInfo(); }

        private void GetAllInfo()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT HQ_Address, HQ_Tel, HQ_Email, HQ_Website From GeneralData WHERE HQ_Address IS NOT NULL", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HQA = reader.GetString(0);
                    HQT = "+31" + reader.GetValue(1).ToString();
                    HQE = reader.GetString(2);
                    HQW = reader.GetString(3);
                }
                cnn.Close();
            }
        }

        public void InvoiceReport()
        {
            r = new Random();
            string reportID = r.Next(100000000).ToString("00000000");

            //creating new Microsoft Word application and using InvoiceTemplate as template
            object fileName = @"C:\Users\Noah\media-bazaar-group-7\Test Data Adder\OrderInvoiceTemplate.Docx";
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

            //finding and replacing text with data
            FindAndReplace(wordApp, "<address>", HQA);
            FindAndReplace(wordApp, "<phone>", HQT);
            FindAndReplace(wordApp, "<email>", HQE);
            FindAndReplace(wordApp, "<website>", HQW);
            FindAndReplace(wordApp, "<reportNumber>", reportID);
            FindAndReplace(wordApp, "<personIC>", "Me Yuong Tama");
            FindAndReplace(wordApp, "<deliveryAddress>", "423 Suckmanuts Dr., IN 46173");
            FindAndReplace(wordApp, "<requestDate>", DateTime.Now.ToString());
            FindAndReplace(wordApp, "<deliveryDate>", DateTime.Now.AddDays(7.00).ToString());
            FindAndReplace(wordApp, "<invoiceNumber>", "IN-34875734");
            FindAndReplace(wordApp, "<employeeName>", "Myname Isthis");
            FindAndReplace(wordApp, "<note>", "--");

            //connecting to db and getting data
            using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Product_ID, Name FROM InventoryData WHERE Store_Address = '" + Address + "'", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    FindAndReplace(wordApp, "<productID>", reader.GetString(0) + "\r\n<productID>");
                cnn.Close();
            }
            using (SqlCommand cmd = new SqlCommand("SELECT Name, count(*) FROM InventoryData WHERE Store_Address = '" + Address + "' GROUP BY Name", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FindAndReplace(wordApp, "<productName>", reader.GetString(0) + "\r\n<productName>");
                    FindAndReplace(wordApp, "<qty>", reader.GetValue(1).ToString() + "\r\n<qty>");
                }
                cnn.Close();
            }
            FindAndReplace(wordApp, "<productID>", "--");
            FindAndReplace(wordApp, "<productName>", "--");
            FindAndReplace(wordApp, "<qty>", "--");

            //saves report as pdf
            ReportTemplate.ExportAsFixedFormat(@"C:\Users\Noah\media-bazaar-group-7\Test Data Adder\DoNotRemove\Report N-" + reportID + ".pdf", mw.WdExportFormat.wdExportFormatPDF);
            email.ID = reportID;
            email.AddAttachments(@"C:\Users\Noah\media-bazaar-group-7\Test Data Adder\DoNotRemove\Report N-" + reportID + ".pdf");

            //disposing report and application
            ReportTemplate.Close(mw.WdSaveOptions.wdDoNotSaveChanges);
            wordApp.Quit();
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
