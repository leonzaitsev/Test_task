using Synevo_test_project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace Synevo_test_project
{
    public static class SendingEmail
    {
       
        public static void Send(PokemonOrder order)
        {
            MailMessage message = new MailMessage();
            message.To.Add(order.Email);
            message.From = new MailAddress ("admin@pokemon.com");
            message.Subject = "Pokemon StartUP: Уведомление о покупке";
            message.Body = "Поздравляем вас! Вы купили покемона";
          
           using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.Credentials = new NetworkCredential("leonzaitsev001@gmail.com", "elitop43");
                smtp.Port = 587;
                smtp.EnableSsl = true;

                smtp.Send(message);
            }         
        }
    }
}
