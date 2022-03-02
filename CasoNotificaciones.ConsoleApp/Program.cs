using CasoNotificaciones.ConsoleApp;
using CasoNotificaciones.ConsoleApp.Models;

var aplicacion = new Aplicacion();
bool finalizado = false;

do
{
    ConsoleKeyInfo respuestaMenu;

    Console.WriteLine("***************** Menu Principal ****************\n");
    Console.WriteLine("1. Enviar mensaje por correo");
    Console.WriteLine("2. Enviar mensaje por Facebook");
    Console.WriteLine("3. Enviar mensaje por SMS");
    Console.WriteLine("4. Enviar mensaje interno");
    Console.WriteLine("5. Enviar mensajes de varios tipos");
    Console.WriteLine("6. Salir\n");
    Console.Write("Ingrese la opcion deseada: ");
    respuestaMenu = Console.ReadKey();

    var mensajes = new List<Mensaje>();

    switch (respuestaMenu.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            mensajes.Add(CrearMensaje(TipoMensaje.Correo));
            aplicacion.EnviarMensaje(mensajes);

            finalizado = ValidarContinuacion();
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            mensajes.Add(CrearMensaje(TipoMensaje.Facebook));
            aplicacion.EnviarMensaje(mensajes);

            finalizado = ValidarContinuacion();
            break;
        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:
            mensajes.Add(CrearMensaje(TipoMensaje.SMS));
            aplicacion.EnviarMensaje(mensajes);

            finalizado = ValidarContinuacion();
            break;
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:
            mensajes.Add(CrearMensaje(TipoMensaje.Interno));
            aplicacion.EnviarMensaje(mensajes);

            finalizado = ValidarContinuacion();
            break;
        case ConsoleKey.D5:
        case ConsoleKey.NumPad5:
            var tiposDeMensajeEscogidos = CapturarMultiplesTiposDeMensaje();

            tiposDeMensajeEscogidos.ForEach(tipoMensaje =>
            {
                mensajes.Add(CrearMensaje(tipoMensaje));
                aplicacion.EnviarMensaje(mensajes);
            });

            finalizado = ValidarContinuacion();
            break;
        case ConsoleKey.D6:
        case ConsoleKey.NumPad6:
            finalizado = true;
            break;
        default:
            Console.WriteLine("\n\nOption invalida, intente con otra diferente\n");
            break;
    }
}
while(!finalizado);

Mensaje CrearMensaje(TipoMensaje tipo)
{
    ImprimirHeaderCreacionDeMensaje(tipo);
    var mensaje = ObtenerDatosDeMensaje();
    mensaje.Tipo = tipo.ToString();

    return mensaje;
}

void ImprimirHeaderCreacionDeMensaje(TipoMensaje tipo)
{
    Console.Clear();

    switch (tipo)
    {
        case TipoMensaje.Correo:
            Console.WriteLine("************* Notificador de correo *************\n");
            break;
        case TipoMensaje.Facebook:
            Console.WriteLine("************* Notificador de Facebook *************\n");
            break;
        case TipoMensaje.SMS:
            Console.WriteLine("************* Notificador de SMS *************\n");
            break;
        case TipoMensaje.Interno:
            Console.WriteLine("************* Notificador interno *************\n");
            break;
    }
}

Mensaje ObtenerDatosDeMensaje() 
{

    var mensaje = new Mensaje
    {
        Destinatarios = new List<string>()
    };

    Console.Write("Ingrese el contenido del mensaje: ");
    mensaje.Contenido = Console.ReadLine();

    ConsoleKeyInfo respuestaDestinatarios = default;

    do
    {
        var destinatario = string.Empty;

        do
        {
            Console.Write("\nIngrese el destinatario: ");
            destinatario = Console.ReadLine();

            if(string.IsNullOrEmpty(destinatario))
            {
                Console.WriteLine("\nEl destinatario no puede estar vacio, ingrese la informacion requerida");
            }
        }
        while (string.IsNullOrEmpty(destinatario));

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

bool ValidarContinuacion()
{
    ConsoleKeyInfo respuestaContinuar;

    do
    {
        Console.Write("\nDesea enviar otro mensaje (S/N): ");
        respuestaContinuar = Console.ReadKey();

        if (respuestaContinuar.Key != ConsoleKey.S && respuestaContinuar.Key != ConsoleKey.N)
        {
            Console.WriteLine("\n\nOpcion invalida, escoja entre S o N");
        }
    }
    while (respuestaContinuar.Key != ConsoleKey.S && respuestaContinuar.Key != ConsoleKey.N);

    if(respuestaContinuar.Key == ConsoleKey.N)
    {
        return true;
    }
    else
    {
        Console.Clear();
        return false;
    }
}

List<TipoMensaje> CapturarMultiplesTiposDeMensaje()
{
    Console.Clear();

    var listaDeMensajes = new List<TipoMensaje>();
    var finalizado = false;

    do
    {
        ConsoleKeyInfo opcionEscogida;

        Console.WriteLine("***************** Seleccione el tipo que desea agregar al envio de mensajes ****************\n");
        Console.WriteLine("1. Correo");
        Console.WriteLine("2. Facebook");
        Console.WriteLine("3. SMS");
        Console.WriteLine("4. Mensaje Interno");
        Console.WriteLine("5. Volver\n");
        Console.Write("Ingrese la opcion deseada: ");
        opcionEscogida = Console.ReadKey();

        switch (opcionEscogida.Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                if (!listaDeMensajes.Contains(TipoMensaje.Correo))
                {
                    listaDeMensajes.Add(TipoMensaje.Correo);

                    Console.WriteLine("\n\n\"Correo\" agregado a los tipos para el siguiente envio\n");
                }
                else
                {
                    Console.WriteLine("\n\nEl correo ya se encuentra entre las opciones agregadas, escoge otra opcion\n");
                }
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                if (!listaDeMensajes.Contains(TipoMensaje.Facebook))
                {
                    listaDeMensajes.Add(TipoMensaje.Facebook);

                    Console.WriteLine("\n\n\"Facebook\" agregado a los tipos para el siguiente envio\n");
                }
                else
                {
                    Console.WriteLine("\n\nFacebook ya se encuentra entre las opciones agregadas, escoge otra opcion\n");
                }
                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                if (!listaDeMensajes.Contains(TipoMensaje.SMS))
                {
                    listaDeMensajes.Add(TipoMensaje.SMS);
                    
                    Console.WriteLine("\n\n\"SMS\" agregado a los tipos para el siguiente envio\n");
                }
                else
                {
                    Console.WriteLine("\n\nSMS ya se encuentra entre las opciones agregadas, escoge otra opcion\n");
                }
                break;
            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                if (!listaDeMensajes.Contains(TipoMensaje.Interno))
                {
                    listaDeMensajes.Add(TipoMensaje.Interno);
                    
                    Console.WriteLine("\n\n\"Mensaje Interno\" agregado a los tipos para el siguiente envio\n");
                }
                else
                {
                    Console.WriteLine("\n\nMensaje interno ya se encuentra entre las opciones agregadas, escoge otra opcion\n");
                }
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
    while (!finalizado);

    return listaDeMensajes;
}

enum TipoMensaje { 
    Correo,
    Facebook,
    SMS,
    Interno
}