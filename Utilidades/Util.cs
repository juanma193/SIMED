using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SIMED_V1
{
    internal class Util
    {

        public static void CrearAlgo()
        {
            //codigo
        }

        public class Encrypt
        {
            public static string GetSHA256(string str)
            {
                SHA256 sha256 = SHA256Managed.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = null;
                StringBuilder sb = new StringBuilder();
                stream = sha256.ComputeHash(encoding.GetBytes(str));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            }

        }
    
        public static bool EmailSender(string mensaje, string to)
        {
            bool bandera = false;
           
            try
            {
                MailMessage message = new MailMessage();

                string from = "equiposimed@gmail.com";
                string pass = "ldjwhmnlqzutccll";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mensaje;
                message.Subject = "Codigo de verificacion";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.Send(message);
                bandera = true;
            }
            catch (Exception ex)
            {

                bandera = false;
                
            }
            return bandera;
        }
    }
}
