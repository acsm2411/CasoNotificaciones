namespace CasoNotificaciones.ConsoleApp.Strategies
{
    public class NotificadorSMS : Notificador
    {
        public NotificadorSMS(List<string> celulares) : base(celulares)
        {

        }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine("\nMensaje a enviar: \"" + mensaje + "\" por correo\n");

            this.Destinatarios.ForEach(destinatario =>
            {
                Console.WriteLine("Mensaje de texto enviado a " + destinatario);
            });
        }
    }
}
