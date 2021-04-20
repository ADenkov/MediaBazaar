using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;

namespace Test_Data_Adder
{
    class Email
    {
        private SmtpClient client;
        private MailMessage mail;
        private List<string> reports;
        private string requester;
        public string ID { private get; set; }
        public Email(string requesterEmail)
        {
            requester = requesterEmail;
            reports = new List<string>();
        }

        public void AddAttachments(string path)
        {
            reports.Add(path);
        }

        public void SendEmail(string email)
        {
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("info.mediabazaar@gmail.com", "mediabazaar");
            mail = new MailMessage();
            mail.From = new MailAddress("info.mediabazaar@gmail.com", "Media Bazaar", Encoding.UTF8);
            mail.To.Add(new MailAddress(email));
            mail.Subject = "Requested Report(s) on " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
            foreach (string f in reports) { mail.Attachments.Add(new Attachment(f)); }
            mail.Body = "<img src='https://i.imgur.com/aKUWMb8.png' width='542' height='39' style='position: absolute; top: 0; left: 0; '><div style='position: absolute; top: 50; left: 0; '><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><br></div><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><div><font face='tahoma, sans - serif' size='6'><b>Hi " + email.Remove(email.IndexOf("@")) + ",</b></font></div></div><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><font size='4'><br></font></div><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><font face='tahoma, sans - serif' size='4'>Here is a copy of the report you requested from the database.<br>Report Number: <b>N-" + ID + "</b><br>Requsted Date: " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "<br><br>Sincerely,<br>Media Bazaar Team<br><br></font></div></div><img src='https://i.imgur.com/YFFodUV.png' width='542' height='118'style='position: absolute; top: 315; left: 0;'>";
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendAsync(mail, "Sending...");
        }

        public void ForwardEmail(string email)
        {
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("info.mediabazaar@gmail.com", "mediabazaar");
            mail = new MailMessage();
            mail.From = new MailAddress("info.mediabazaar@gmail.com", "Media Bazaar", Encoding.UTF8);
            mail.To.Add(new MailAddress(email));
            mail.Subject = "Report(s) sent to you by " + requester;
            foreach(string f in reports) { mail.Attachments.Add(new Attachment(f)); }
            mail.Body = "<img src='https://i.imgur.com/aKUWMb8.png' width='542' height='39' style='position: absolute; top: 0; left: 0; '><div style='position: absolute; top: 50; left: 0; '><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><br></div><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><div><font face='tahoma, sans - serif' size='6'><b>Hi " + email.Remove(email.IndexOf("@")) + ",</b></font></div></div><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><font size='4'><br></font></div><div style='margin: 0px 0px 0px 40px; border: none; padding: 0px'><font face='tahoma, sans - serif' size='4'>Here is a copy of your report you requested from the database.<br>Report Number: <b>N-" + ID + "</b><br>Requsted Date: " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "<br><br>Should you have any queries regarding this email,<br>contact: <b>" + requester + "</b><br><br>Sincerely,<br>Media Bazaar Team<br><br></font></div></div><img src='https://i.imgur.com/YFFodUV.png' width='542' height='118'style='position: absolute; top: 315; left: 0;'>";
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendAsync(mail, "Sending...");
        }
    }
}
