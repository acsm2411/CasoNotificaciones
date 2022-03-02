namespace CasoNotificaciones.ConsoleApp.Strategies
{
    public class NotificadorFacebook : Notificador
    {
        public NotificadorFacebook(List<string> correos) : base(correos)
        {

        }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine("\nMensaje a enviar: \"" + mensaje + "\" por Facebook\n");

            this.Destinatarios.ForEach(destinatario =>
            {
                Console.WriteLine("Mensaje enviado a " + destinatario);
            });
        }
    }
}
