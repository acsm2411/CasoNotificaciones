using CasoNotificaciones.API.Strategies;

namespace CasoNotificaciones.API.Services
{
    public interface INotificadorCreatorService
    {
        public Notificador CrearNotificador(string tipo, List<string> destinatarios);
    }
}
