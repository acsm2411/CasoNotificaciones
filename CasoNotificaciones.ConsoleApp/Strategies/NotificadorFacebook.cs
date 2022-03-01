namespace CasoNotificaciones.ConsoleApp.Strategies
{
    public class NotificadorFacebook : Notificador
    {
        public NotificadorFacebook(List<string> correos) : base(correos)
        {

        }

        public override void Enviar(string mensaje)
        {
            this.Destinatarios.ForEach(destinatario =>
            {
                //Enviar Mensaje Facebook
            });
        }
    }
}
