namespace CasoNotificaciones.ConsoleApp.Strategies
{
    public class NotificadorInterno : Notificador
    {
        public NotificadorInterno(List<string> correos) : base(correos)
        {

        }

        public override void Enviar(string mensaje)
        {
            this.Destinatarios.ForEach(destinatario =>
            {
                //Enviar Mensaje Interno
            });
        }
    }
}
