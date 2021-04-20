using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Test_Data_Adder
{
    public partial class EmailForm : Form
    {
        SmtpClient client;
        MailMessage mail;
        string id;

        public EmailForm()
        {
            InitializeComponent();
            Random digit = new Random();
            id = digit.Next(0, 100000000).ToString("00000000");
            tbTo.Text = "greffnoah@gmail.com"; tbSubject.Text = "Invoice Request N-" + id;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("info.mediabazaar@gmail.com", "mediabazaar");
            mail = new MailMessage();
            mail.From = new MailAddress("info.mediabazaar@gmail.com", "Requested Report", Encoding.UTF8);
            mail.To.Add(new MailAddress(tbTo.Text));
            if (!string.IsNullOrEmpty(tbCC.Text)) { mail.To.Add(new MailAddress(tbCC.Text)); }
            mail.Subject = tbSubject.Text;
            mail.Body = "<img src='https://i.imgur.com/aKUWMb8.png' width='542' height='39' style='position: absolute; top: 0; left: 0; '><div style='position: absolute; top: 50; left: 0; '><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><br></div><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><div><font face='tahoma, sans - serif' size='6'><b>Hi " + tbTo.Text.Remove(tbTo.Text.IndexOf("@")) + ",</b></font></div></div><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><font size='4'><br></font></div><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><font face='tahoma, sans - serif' size='4'>Here is a copy of your report you requested from the database.<br>Report Number: <b>N-" + id + "</b><br>Requsted Date: " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "<br><br>Should you have any queries regarding this email,<br>contact: <b>" + tbTo.Text + "</b><br><br>Sincerely,<br>Media Bazaar Team<br><br></font></div></div><img src='https://i.imgur.com/YFFodUV.png' width='542' height='118'style='position: absolute; top: 315; left: 0;'>";
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
            client.SendAsync(mail, "Sending...");
        }

        private static void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState));
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error));
            else
                MessageBox.Show("Message sent successfully.");
        }
    }
}
