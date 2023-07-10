using System.Net;
using System.Net.Mail;

// SMTP server ayarları 
string SMTP_Server = "smtp.example.com";
int SMTP_Port = 587;

// Gönderici bilgileri 
string From = "sender@example.com";
string From_Password = "password";

// Alıcı bilgileri 
string To = "recipient@example.com";

// E-posta mesajı 
MailMessage mail = new MailMessage();
mail.From = new MailAddress(From);
mail.To.Add(To);
mail.Subject = "Subject";
mail.Body = "Message";

// SMTP server ile bağlantı 
SmtpClient smtp = new SmtpClient(SMTP_Server, SMTP_Port);
smtp.Credentials = new NetworkCredential(From, From_Password);
smtp.EnableSsl = true;

// E-posta gönderme 
smtp.Send(mail);