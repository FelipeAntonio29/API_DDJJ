using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AccesoNegocio.Implementacion
{
    public class ImplUtiles
    {
        public static void SendEmail(string messagesSend, bool bodyHtml)
        {
            if (ConfigurationManager.AppSettings["SendMail"].ToString() == Convert.ToInt32(ESendMail.Si).ToString())
            {
                using (MailMessage emailSend = new MailMessage())
                {
                    emailSend.From = new MailAddress(ConfigurationManager.AppSettings["EmailFrom"].ToString(), ConfigurationManager.AppSettings["EmailMask"].ToString());

                    List<string> emailSendTo = new List<string>();
                    string mailTo = ConfigurationManager.AppSettings["EmailTo"].ToString();
                    IList<string> listMailTo = mailTo.Split(new string[] { ConfigurationManager.AppSettings["SplitEmailTo"].ToString() }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    foreach (string valueEmailTo in listMailTo)
                    {
                        if (!emailSendTo.Contains(valueEmailTo))
                        {
                            emailSend.To.Add(valueEmailTo);
                            emailSendTo.Add(valueEmailTo);
                        }
                    }

                    emailSend.Subject = ConfigurationManager.AppSettings["EmailSubject"].ToString();

                    emailSend.IsBodyHtml = true;
                    emailSend.Body = messagesSend;

                    SmtpClient smtpClient = new SmtpClient(ConfigurationManager.AppSettings["SmtpClient"].ToString());
                    smtpClient.Send(emailSend);
                }
            }

        }
        public enum ESendMail
        {
            No = 0,
            Si = 1
        }
        public static XmlDocument GenerarXML(Object obj)
        {
            XmlSerializer ser = new XmlSerializer(obj.GetType());

            XmlDocument xd = null;

            using (MemoryStream memStm = new MemoryStream())
            {
                ser.Serialize(memStm, obj);

                memStm.Position = 0;

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;

                using (var xtr = XmlReader.Create(memStm, settings))
                {
                    xd = new XmlDocument();
                    xd.Load(xtr);
                }
            }

            return xd;

        }




    }
}
