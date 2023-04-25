using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using AppVeterinariaUCR.Models;

namespace AppVeterinariaUCR.Data
{
    public class Email
    {
        public void enviar(Usuarios usuario, string urlFirma)
        {
            try
            {
                //Se crea una instancia del objeto email
                MailMessage email = new MailMessage();

                //agregar destinatarios
                //email del administardor para que reciba una copia 
                email.To.Add(new MailAddress("AspCrPacifico@gmail.com"));

                //Se agrega el email del usuario guardado 
                email.To.Add(new MailAddress(usuario.Email));

                //se agrega el emisor 
                email.From = new MailAddress("AspCrPacifico@gmail.com");

                //asunto del email
                email.Subject = "Datos de registro en plataforma web Veterinaria CR";

                //se construye la vista html del body del email
                string html = "Bienvenidos a Veterinaria CR gracias por formar parte de nuestra plataforma web";
                html += "<br> A continuacion detallamos los datos registrados en nuestra plataforma web";
                html += "<br><b>Login:<b>" + usuario.Login;
                html += "<br><b>Nombre:<b>" + usuario.Nombre;
                html += "<br><b>Email:<b>" + usuario.Email;
                html += "<br><b>Password:<b>" + usuario.Password;
                html += "<br><b>No responda este correo porque fue generado de forma automatica";
                html += "por la plataforma web Veterinaria CR </b>";

                //se indica en contenido es html
                email.IsBodyHtml = true;

                //se indica la prioridad del email
                email.Priority = MailPriority.Normal;

                //Aqui se crea el adjunto de la fotografia utilizada como firma
                Attachment attachment = new Attachment(urlFirma);

                //Se crea la etiqueta img para agregar la imagen como firma al body del email
                html += "<br><br><img src:'cid:imagen' />";

                //se crea la instancia para la vista html del body del email 
                AlternateView view = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);
                //Se crea la instancia del object inscrustado como imjagen de archivo adjunto 
                LinkedResource img = new LinkedResource(urlFirma, MediaTypeNames.Image.Jpeg);

                //Se indica el id para la imagen 
                img.ContentId = "imagen";

                //se adjunta la imagen
                view.LinkedResources.Add(img);

                //se agrega la vista al email
                email.AlternateViews.Add(view);

                //Se instancia a un object smtpClient
                SmtpClient smtp = new SmtpClient();

                //Se indica el servidor de correo a implementar
                smtp.Host = "smtp.gmail.com";

                // el puerto de comunicacion 
                smtp.Port = 587;

                //Se indica si utiliza seguridad ssl
                smtp.EnableSsl = true;

                //Se indica si tenemos credenciales por default 
                //en esete caso no
                smtp.UseDefaultCredentials = false;

                //aqui indicamos las credenciales del buzon de correo
                smtp.Credentials = new NetworkCredential("AspCrPacifico@gmail.com","Ucr2021*");
                // se envia el email
                smtp.Send(email);

                //Se liberan los recursos
                email.Dispose();
                smtp.Dispose();
                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
