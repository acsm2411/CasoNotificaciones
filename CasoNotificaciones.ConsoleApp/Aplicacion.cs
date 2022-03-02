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

        public void EnviarMensaje(List<Mensaje> mensajes)
        {
            if (mensajes.Count != 0)
            {
                mensajes.ForEach(mensaje =>
                {
                    var notificador = creatorService.CrearNotificador(mensaje.Tipo, mensaje.Destinatarios);
                    notificador.Enviar(mensaje.Contenido);
                });
            }
            else
            {
                throw new Exception("Debe haber al menos un mensaje para continuar con la operacion");
            }
        }
    }
}
