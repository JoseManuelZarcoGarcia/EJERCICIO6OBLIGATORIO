using EJERCICIO6OBLIGATORIO.Dtos;
using EJERCICIO6OBLIGATORIO.Servicios;

namespace EJERCICIO6OBLIGATORIO.Controladores
{

    /// <summary>
    /// Clase principal por la que iniciara la aplicacion
    /// 160124 - jzg
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo main por donde inicia la app
        /// 160124 - jzg
        /// </summary>
        /// <param name="args"></param>
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

                    default:
                        Console.WriteLine("no es una opcion valida");
                        cerrar = false;
                        break;

                }
            }


        }

    }

}