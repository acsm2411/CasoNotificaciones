namespace CasoNotificaciones.ConsoleApp.Strategies
{
    public abstract class Notificador
    {
        //Esta lista puede contener correos o numeros de telefono dependiendo de la necesidad
        public List<string> Destinatarios { get; private set; }

        public Notificador(List<string> destinatarios)
        {
            this.Destinatarios = destinatarios;
        }

        public abstract void Enviar(string mensaje);
    }
}
