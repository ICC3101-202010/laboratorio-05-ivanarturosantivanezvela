using System;
using System.Threading;
namespace Laboratorio5Ivan
{
    public class User
    {
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);
        public event EmailVerifiedEventHandler EmailVerified;

        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {

                EmailVerified(this, EventArgs.Empty);
            }



        }


        public void OnEmailSented(object source, EventArgs e)
        {

            Console.WriteLine("Desea mandar un correo de verificacion ? (Escriba su opcion numerica 1 o 2)");
            Console.WriteLine("1) si  ");
            Console.WriteLine("2) no  ");
            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                Thread.Sleep(2000);
                OnEmailVerified();
                

            }
            if (respuesta == "2")
            {
                Console.WriteLine("No se envio correo de verificacion ");
            }


        }



    }
}
