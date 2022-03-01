namespace CasoNotificaciones.ConsoleApp.Models
{
    public class Mensaje
    {
        public string Tipo { get; set; }
        public string Contenido { get; set; }
        public List<string> Destinatarios { get; set; }
    }
}
