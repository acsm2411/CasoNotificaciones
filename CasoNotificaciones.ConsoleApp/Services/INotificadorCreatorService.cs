using CasoNotificaciones.ConsoleApp.Strategies;

namespace CasoNotificaciones.ConsoleApp.Services
{
    public interface INotificadorCreatorService
    {
        public Notificador CrearNotificador(string tipo, List<string> destinatarios);
    }
}
