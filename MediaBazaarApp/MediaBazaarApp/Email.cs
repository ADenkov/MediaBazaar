using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;

namespace MediaBazaarApp
{
    class Email
    {
        private SmtpClient client;
        private MailMessage mail;
        private readonly EmployeeProfile ep;
        private List<string> reports;
        private DeliveryCollection dc;

        public Email(EmployeeProfile ep, DeliveryCollection dc)
        {
            this.dc = dc;
            this.ep = ep;
        }

        private void SendEmail(string email, string subject, string body)
        {
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("info.mediabazaar@gmail.com", "mediabazaar");
            mail = new MailMessage();
            mail.From = new MailAddress("info.mediabazaar@gmail.com", "no reply", Encoding.UTF8);
            mail.To.Add(new MailAddress(email));
            mail.Subject = subject;
            mail.Body = body;
            if(reports != null) { foreach (string r in reports) { mail.Attachments.Add(new Attachment(r)); } }
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendAsync(mail, "Sending...");
        }

        public void AddAttachments(bool IsNewListOfAttachements, string path)
        {
            if (IsNewListOfAttachements)
                reports = new List<string>();
            reports.Add(path);
        }

        public void SendReport(string email)
        {
            string subject = "Requested Report(s) on " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
            string body = "<img src='https://i.imgur.com/aKUWMb8.png' width='542' height='39' style='position: absolute; top: 0; left: 0; '><div><br></div><div><font face='tahoma, sans - serif' size='6'><b>&nbsp;Hi " + ep.First + ",</b></font></div><div><br></div><div>&nbsp; &nbsp; &nbsp;This email contains the order report that you have requested.</div><div><br></div><div>&nbsp; &nbsp; &nbsp;Report ID:&nbsp; &nbsp; &nbsp;<b>" + dc.GetDeliveryInfo().OrderID + "</b></div><div>&nbsp; &nbsp; &nbsp;Address:&nbsp; &nbsp; &nbsp; &nbsp; " + ep.Store + "</div><div>&nbsp; &nbsp; &nbsp;Date:&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "</div><div>&nbsp; &nbsp; &nbsp;___________________________________________</div><div><br></div><div>&nbsp; &nbsp; &nbsp;This is an automated email for document requests only.</div><div><br></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;MEDIA BAZAAR HQ,</font></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;" + ep.Store + "</font></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;" + ep.Phone + "</font></div><div><br></div><img src='https://i.imgur.com/YFFodUV.png' width='542' height='118' style='position: absolute; top: 315; left: 0;'>";
            SendEmail(email, subject, body);
        }

        public void ForwardReport(string email)
        {
            string subject = "Report(s) sent to you by " + ep.Email;
            string body = "<img src='https://i.imgur.com/aKUWMb8.png' width='542' height='39' style='position: absolute; top: 0; left: 0; '><div><br></div><div><font face='tahoma, sans - serif' size='6'><b>&nbsp;Hi " + email.Remove(email.IndexOf('@')) + ",</b></font></div><div><br></div><div>&nbsp; &nbsp; &nbsp;This email has forwarded to you containing an order report.</div><div><br></div><div>&nbsp; &nbsp; &nbsp;Report ID:&nbsp; &nbsp; &nbsp;<b>" + dc.GetDeliveryInfo().OrderID + "</b></div><div>&nbsp; &nbsp; &nbsp;Address:&nbsp; &nbsp; &nbsp; &nbsp; " + ep.Store + "</div><div>&nbsp; &nbsp; &nbsp;Date:&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "</div><div>&nbsp; &nbsp; &nbsp;___________________________________________</div><div><br></div><div>&nbsp; &nbsp; &nbsp;This is an automated email for document requests only.</div><div>&nbsp; &nbsp; &nbsp;Should you have any queries regarding the content of this email,</div><div>&nbsp; &nbsp; &nbsp;contact: " + ep.Email + ".</div><div><br></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;MEDIA BAZAAR HQ,</font></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;" + ep.Store + "</font></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;" + ep.Phone + "</font></div><div><br></div><img src='https://i.imgur.com/YFFodUV.png' width='542' height='118' style='position: absolute; top: 315; left: 0;'>";
            SendEmail(email, subject, body);
        }

        public void UpdatedCredentials(string email)
        {
            string subject = "Information Update";
            string body = "<img src='https://i.imgur.com/aKUWMb8.png' width='542' height='39' style='position: absolute; top: 0; left: 0; '><div><br></div><div><font face='tahoma, sans - serif' size='6'><b>&nbsp;Hi " + email.Remove(email.IndexOf('@')) + ",</b></font></div><div><br></div><div>&nbsp; &nbsp; &nbsp;Some of your credentials have been modified.<br>&nbsp; &nbsp; &nbsp;<b>Login to your account to view your changes.</b></div><div><br></div><div>&nbsp; &nbsp; &nbsp;This is an automated email for document requests only.</div><div>&nbsp; &nbsp; &nbsp;Should you have any queries regarding the content of this email,</div><div>&nbsp; &nbsp; &nbsp;contact: " + ep.Email + ".</div><div><br></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;MEDIA BAZAAR HQ,</font></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;" + ep.Store + "</font></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;" + ep.Phone + "</font></div><div><br></div><img src='https://i.imgur.com/YFFodUV.png' width='542' height='118' style='position: absolute; top: 315; left: 0;'>";
            SendEmail(email, subject, body);
        }

        public void SendAnnoucement(string email, string title, string message)
        {
            string subject = "New Annoucement: " + title;
            string body = "<img src='https://i.imgur.com/aKUWMb8.png' width='542' height='39' style='position: absolute; top: 0; left: 0; '><div><br></div><div><font face='tahoma, sans - serif' size='6'><b>&nbsp;Hi " + email.Remove(email.IndexOf('@')) + ",</b></font></div><div><br></div><div>&nbsp; &nbsp; &nbsp;<b>" + title + "</b></div><div>";

            // word organiser algorithm -> fkin lit
            string line = "";
            string word = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] != ' ')
                    word += message[i];
                else
                {
                    if (line.Length + word.Length >= 80)
                    {
                        body += "<br>&nbsp; &nbsp; &nbsp;" + line;
                        line = word + " ";
                    }
                    else
                        line += word + " ";
                    word = "";
                }
            }
            if (line.Length != 0)
                body += "<br>&nbsp; &nbsp; &nbsp;" + line;

            body += "</div><div>&nbsp; &nbsp; &nbsp;___________________________________________</div><div><br></div><div>&nbsp; &nbsp; &nbsp;This is an automated email for document requests only.</div><div>&nbsp; &nbsp; &nbsp;Should you have any queries regarding the content of this email,</div><div>&nbsp; &nbsp; &nbsp;contact: " + ep.Email + ".</div><div><br></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;MEDIA BAZAAR HQ,</font></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;Address 1234 Example, The Netherlands</font></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;+123456789</font></div><div><br></div><img src='https://i.imgur.com/YFFodUV.png' width='542' height='118' style='position: absolute; top: 315; left: 0;'>";
            SendEmail(email, subject, body);
        }
    }
}
