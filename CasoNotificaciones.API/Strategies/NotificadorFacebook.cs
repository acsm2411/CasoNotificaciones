namespace CasoNotificaciones.API.Strategies
{
    public class NotificadorFacebook : Notificador
    {
        public NotificadorFacebook(List<string> correos) : base(correos)
        {

        }

        public override void Enviar(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
