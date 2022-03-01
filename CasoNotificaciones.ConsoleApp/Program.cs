using CasoNotificaciones.ConsoleApp.Models;
using CasoNotificaciones.ConsoleApp;

var aplicacion = new Aplicacion();
bool finalizado = false;

do
{
    ConsoleKeyInfo respuestaMenu = default;

    Console.WriteLine("***************** Menu Principal ****************\n");
    Console.WriteLine("1. Enviar mensaje por correo");
    Console.WriteLine("2. Enviar mensaje por Facebook");
    Console.WriteLine("3. Enviar mensaje por SMS");
    Console.WriteLine("4. Enviar mensaje interno");
    Console.WriteLine("5. Salir\n");
    Console.Write("Ingrese la opcion deseada: ");
    respuestaMenu = Console.ReadKey();

    Mensaje mensaje;

    switch (respuestaMenu.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            mensaje = ObtenerDatosDeMensaje();
            mensaje.Tipo = "Correo";
            aplicacion.EnviarMensaje(mensaje);
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            mensaje = ObtenerDatosDeMensaje();
            mensaje.Tipo = "Facebook";
            aplicacion.EnviarMensaje(mensaje);
            break;
        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:
            mensaje = ObtenerDatosDeMensaje();
            mensaje.Tipo = "SMS";
            aplicacion.EnviarMensaje(mensaje);
            break;
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:
            mensaje = ObtenerDatosDeMensaje();
            mensaje.Tipo = "Interno";
            aplicacion.EnviarMensaje(mensaje);
            break;
        case ConsoleKey.D5:
        case ConsoleKey.NumPad5:
            finalizado = true;
            break;
        default:
            Console.WriteLine("\n\nOption invalida, intente con otra diferente\n");
            break;
    }
}
while(!finalizado);

Mensaje ObtenerDatosDeMensaje() 
{
    var mensaje = new Mensaje
    {
        Destinatarios = new List<string>()
    };

    Console.Write("\n\nIngrese el contenido del mensaje: ");
    mensaje.Contenido = Console.ReadLine();

    ConsoleKeyInfo respuestaDestinatarios = default;

    do
    {
        var destinatario = string.Empty;

        do
        {
            Console.Write("\nIngrese el destinatario: ");
            destinatario = Console.ReadLine();

            if(destinatario.Length == 0)
            {
                Console.WriteLine("\n\nEl destinatario no puede estar vacio, ingrese la informacion requerida\n");
            }
        }
        while (destinatario.Length == 0);

        mensaje.Destinatarios.Add(destinatario);

        do
        {
            Console.Write("\nHay mas destinatarios? (S/N): ");
            respuestaDestinatarios = Console.ReadKey();

            if(respuestaDestinatarios.Key != ConsoleKey.S && respuestaDestinatarios.Key != ConsoleKey.N)
            {
                Console.WriteLine("\n\nOpcion invalida, escoja entre S o N");
            }
            else
            {
                Console.WriteLine();
            }
        }
        while (respuestaDestinatarios.Key != ConsoleKey.S && respuestaDestinatarios.Key != ConsoleKey.N);
    }
    while (respuestaDestinatarios.Key != ConsoleKey.N);

    return mensaje;
}