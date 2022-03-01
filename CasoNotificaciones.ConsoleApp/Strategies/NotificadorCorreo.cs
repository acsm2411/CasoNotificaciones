namespace CasoNotificaciones.ConsoleApp.Strategies
{
    public class NotificadorCorreo : Notificador
    {
        public NotificadorCorreo(List<string> correos) : base(correos)
        {

        }

        public override void Enviar(string mensaje)
        {
            this.Destinatarios.ForEach(destinatario =>
            {
                //Enviar Correo
            });
        }
    }
}
