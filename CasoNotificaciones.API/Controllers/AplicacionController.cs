using CasoNotificaciones.API.DTOs;
using CasoNotificaciones.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CasoNotificaciones.API.Controllers
{
    [ApiController]
    [Route("[controller]/api")]
    public class AplicacionController : ControllerBase
    {
        private readonly INotificadorCreatorService creatorService;

        public AplicacionController()
        {
            this.creatorService = new NotificadorCreatorService();
        }

        [HttpPost]
        [Route("EnviarMensaje")]
        public IActionResult EnviarMensaje(MensajeDTO mensaje)
        {
            if(mensaje != null)
            {
                var notificador = creatorService.CrearNotificador(mensaje.Tipo, mensaje.Destinatarios);
                notificador.Enviar(mensaje.Contenido);

                return Ok();
            }
            else 
            {
                return BadRequest();
            }
        }
    }
}
