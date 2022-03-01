namespace CasoNotificaciones.API.Strategies
{
    public class NotificadorCorreo : Notificador
    {
        public NotificadorCorreo(List<string> correos) : base(correos)
        {

        }

        public override void Enviar(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
