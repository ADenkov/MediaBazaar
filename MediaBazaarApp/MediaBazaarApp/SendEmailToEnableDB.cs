using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class SendEmailToEnableDB
    {
        private SmtpClient client;
        private MailMessage mail;
        private List<string> emails;

        public SendEmailToEnableDB(string help, string ip, string db, string user, string pass, string note)
        {
            emails = new List<string>();
            emails.Add("greffnoah@gmail.com");
            emails.Add("info.mediabazaar@gmail.com");
            emails.Add("e.markvoort@student.fontys.nl");
            emails.Add("n.toulouse@student.fontys.nl");
            emails.Add("a.denkov@student.fontys.nl");
            emails.Add("k.hadjiyankov@student.fontys.nl");
            foreach (string email in emails)
                SendEmail(help, email, ip, db, user, pass, note);
        }

        private void SendEmail(string help, string email, string ip, string db, string user, string pass, string message)
        {
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("info.mediabazaar@gmail.com", "mediabazaar");
            mail = new MailMessage();
            mail.From = new MailAddress("info.mediabazaar@gmail.com", "no reply", Encoding.UTF8);
            mail.To.Add(new MailAddress(email));
            mail.Subject = "ALERT - Someone is trying to connect to DB";
            mail.Body = "<img src='https://i.imgur.com/aKUWMb8.png' width='542' height='39' style='position: absolute; top: 0; left: 0; '><div><br></div><div><font face='tahoma, sans - serif' size='6'><b>&nbsp;Hi " + email.Remove(email.IndexOf('@')) + ",</b></font><font face='fira code, monospace' color='black'></div><div><br></div><div>&nbsp; &nbsp; &nbsp;Someone is trying to use the C# applcation but is enable to connect to the DB.</div><div><br></div><div>&nbsp; &nbsp; &nbsp;IP Server:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>" + ip + "</b></div><div>&nbsp; &nbsp; &nbsp;Database:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>" + db + "</b></div><div>&nbsp; &nbsp; &nbsp;User:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>" + user + "</b></div><div>&nbsp; &nbsp; &nbsp;Pass:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>" + pass + "</b></div><div></font>&nbsp; &nbsp; &nbsp;___________________________________________</div><div><br></div><div>&nbsp; &nbsp; &nbsp;Contact: <b>" + help + "</b></div>";

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
                        mail.Body += "<br>&nbsp; &nbsp; &nbsp;" + line;
                        line = word + " ";
                    }
                    else
                        line += word + " ";
                    word = "";
                }
            }
            if (line.Length != 0)
                mail.Body += "<br>&nbsp; &nbsp; &nbsp;" + line;

            mail.Body += "<div><br></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;MEDIA BAZAAR,</font></div><div><font size='1'>&nbsp; &nbsp; &nbsp; &nbsp;Fontys (Eindhoven), The Netherlands.</font></div><div><div><br></div><img src='https://i.imgur.com/YFFodUV.png' width='542' height='118' style='position: absolute; top: 315; left: 0;'>";
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendAsync(mail, "Sending...");
        }
    }
}
