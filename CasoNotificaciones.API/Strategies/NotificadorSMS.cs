namespace CasoNotificaciones.API.Strategies
{
    public class NotificadorSMS : Notificador
    {
        public NotificadorSMS(List<string> celulares) : base(celulares)
        {

        }

        public override void Enviar(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
