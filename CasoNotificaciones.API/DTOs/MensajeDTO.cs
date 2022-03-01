using Newtonsoft.Json;

namespace CasoNotificaciones.API.DTOs
{
    public class MensajeDTO
    {
        [JsonProperty("tipo")]
        public string Tipo { get; set; }
        [JsonProperty("contenido")]
        public string Contenido { get; set; }
        [JsonProperty("detinatarios")]
        public List<string> Destinatarios { get; set; }
    }
}
