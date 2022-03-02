namespace CasoNotificaciones.ConsoleApp.Strategies
{
    public class NotificadorCorreo : Notificador
    {
        public NotificadorCorreo(List<string> correos) : base(correos)
        {

        }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine("\nMensaje a enviar: \"" + mensaje + "\" por correo\n");

            this.Destinatarios.ForEach(destinatario =>
            {
                Console.WriteLine("Correo enviado a " + destinatario);
            });
        }
    }
}
