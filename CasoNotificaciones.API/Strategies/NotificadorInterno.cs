namespace CasoNotificaciones.API.Strategies
{
    public class NotificadorInterno : Notificador
    {
        public NotificadorInterno(List<string> correos) : base(correos)
        {

        }

        public override void Enviar(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
