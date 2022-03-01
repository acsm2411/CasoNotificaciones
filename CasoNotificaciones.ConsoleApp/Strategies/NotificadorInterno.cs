namespace CasoNotificaciones.ConsoleApp.Strategies
{
    public class NotificadorInterno : Notificador
    {
        public NotificadorInterno(List<string> correos) : base(correos)
        {

        }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine("\nMensaje a enviar: \"" + mensaje + "\" por chat interno\n");

            this.Destinatarios.ForEach(destinatario =>
            {
                Console.WriteLine("Mensaje enviado a " + destinatario);
            });

            Console.WriteLine();
        }
    }
}
