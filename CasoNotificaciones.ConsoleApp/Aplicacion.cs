using CasoNotificaciones.ConsoleApp.Models;
using CasoNotificaciones.ConsoleApp.Services;

namespace CasoNotificaciones.ConsoleApp
{
    public class Aplicacion
    {
        private readonly INotificadorCreatorService creatorService;

        public Aplicacion()
        {
            this.creatorService = new NotificadorCreatorService();
        }

        public void EnviarMensaje(Mensaje mensaje)
        {
            if (mensaje != null)
            {
                var notificador = creatorService.CrearNotificador(mensaje.Tipo, mensaje.Destinatarios);
                notificador.Enviar(mensaje.Contenido);
            }
            else
            {
                throw new Exception("El objeto mensaje no puede ser nulo");
            }
        }
    }
}
