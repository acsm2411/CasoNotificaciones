using CasoNotificaciones.API.Strategies;

namespace CasoNotificaciones.API.Services
{
    public class NotificadorCreatorService : INotificadorCreatorService
    {
        public Notificador CrearNotificador(string tipo, List<string> destinatarios)
        {
            return tipo switch
            {
                "Correo" => new NotificadorCorreo(destinatarios),
                "Facebook" => new NotificadorFacebook(destinatarios),
                "SMS" => new NotificadorSMS(destinatarios),
                "Interno" => new NotificadorInterno(destinatarios),
                _ => throw new Exception("Tipo no valido"),
            };
        }
    }
}
