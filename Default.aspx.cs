using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EmailSenderApp
{
     public partial class Default : System.Web.UI.Page
     {
          protected void btnSend_Click(object sender, EventArgs e)
          {
               string senderEmail = txtSender.Text.Trim().ToLower();
               string receiverEmail = txtReceiver.Text.Trim().ToLower();
               string subject = txtSubject.Text.Trim().ToUpper();
               string message = txtMessage.Text.Trim();

               // Validate email addresses
               string emailPattern = @"^[a-zA-Z0-9._%+-]+@anu\.ac\.ke$";
               if (!Regex.IsMatch(senderEmail, emailPattern) || !Regex.IsMatch(receiverEmail, emailPattern))
               {
                    lblStatus.Text = "Both sender and receiver must use valid ANU email addresses.";
                    return;
               }

               try
               {
                    // SMTP Configuration
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                    {
                         Credentials = new NetworkCredential("youranuemail@anu.edu", "your_app_password"),
                         EnableSsl = true
                    };

                    MailMessage mail = new MailMessage
                    {
                         From = new MailAddress(senderEmail),
                         Subject = subject,
                         Body = message
                    };

                    mail.To.Add(receiverEmail);

                    smtpClient.Send(mail);
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    lblStatus.Text = "Email sent successfully!";
               }
               catch (Exception ex)
               {
                    lblStatus.Text = $"Error: {ex.Message}";
               }
          }
     }
}
