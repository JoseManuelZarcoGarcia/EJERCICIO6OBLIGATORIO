using EJERCICIO6OBLIGATORIO.Dtos;
using EJERCICIO6OBLIGATORIO.Servicios;

namespace EJERCICIO6OBLIGATORIO.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {


            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            List<ClienteDto> listaCliente = new List<ClienteDto>();

            bool cerrar = false;
            int opcionSeleccionada;

            while (!cerrar)
            {
                opcionSeleccionada = mi.mostrarMenu();

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrar = true;
                        break;

                    case 1:
                        ci.altaCliente(listaCliente);
                        break;

                    case 2:
                        ci.validarOrdenarCliente(listaCliente);
                        cerrar = false;
                        break;

                    case 3:
                        foreach (ClienteDto cuberteria in listaCliente)
                        {
                            Console.WriteLine(cuberteria.ToString());
                        }

                        cerrar = false;
                        break;

                    default:
                        Console.WriteLine("no es una opcion valida");
                        cerrar = false;
                        break;

                }
            }


        }

    }

}