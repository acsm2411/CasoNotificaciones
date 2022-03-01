namespace CasoNotificaciones.ConsoleApp.Strategies
{
    public class NotificadorSMS : Notificador
    {
        public NotificadorSMS(List<string> celulares) : base(celulares)
        {

        }

        public override void Enviar(string mensaje)
        {
            this.Destinatarios.ForEach(destinatario =>
            {
                //Enviar SMS
            });
        }
    }
}
