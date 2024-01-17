using EJERCICIO6OBLIGATORIO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6OBLIGATORIO.Servicios
{

    /// <summary>
    /// Clase que contien los metodos relacionados con los clientes
    /// 160124 - jzg
    /// </summary>
    internal class ClienteImplementacion : ClienteInterfaz
    {

        List<ClienteDto> listaCliente = new List<ClienteDto>();
        MenuInterfaz mi = new MenuImplementacion();

        /// <summary>
        /// Metodo que crea el cliente y lo mete en la lista
        /// 160124 - jzg
        /// </summary>
        /// <param name="listaCliente"></param>
        /// <returns></returns>
        public List<ClienteDto> altaCliente(List<ClienteDto> listaCliente)
        {
            ClienteDto cliente = new ClienteDto();
            cliente = crearNuevoCliente();

            listaCliente.Add(cliente);

            return listaCliente;
        }

        /// <summary>
        /// Metodo pide los valores de los atributos del cliente a crear
        /// 160124 - jzg
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearNuevoCliente() 
        {

            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("introduzca una id: ");
            nuevoCliente.IdCliente = (Convert.ToInt64(Console.ReadLine()));

            Console.WriteLine("introduzca su nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("introduzca su apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            nuevoCliente.NombreCompletoCliente = nuevoCliente.NombreCliente + " " + nuevoCliente.ApellidosCliente;

            Console.WriteLine("introduzca su edad: ");
            nuevoCliente.Edad = Convert.ToInt32(Console.ReadLine());


            return nuevoCliente;

        }
        
        /// <summary>
        /// Metodo que ordena la lista de forma descendete segun la edad
        /// 160124 - jzg
        /// </summary>
        /// <param name="listaCliente"></param>
        /// <returns></returns>

        private List<ClienteDto> ordenarCliente(List<ClienteDto> listaCliente)
        {
            // Metodo burbuja

            for (int f = 0; f < listaCliente.Count; f++)
            {
                for (int c = 0; c < listaCliente.Count - 1 - f; c++)
                {
                    // ( cambiando el simbolo mayor que, cambiamos la condicion a cumplir )
                    if (listaCliente[c + 1].Edad > listaCliente[c].Edad)
                    {
                        ClienteDto aux = listaCliente[c + 1];
                        listaCliente[c + 1] = listaCliente[c];
                        listaCliente[c] = aux;
                    }

                }
            }



            return listaCliente;

        }


        /// <summary>
        /// Metodo que valida si en la lista hay 3 o más clientes
        /// 160124 - jzg
        /// </summary>
        /// <param name="listaCliente"></param>
        /// <returns></returns>

        public List<ClienteDto> validarOrdenarCliente(List<ClienteDto> listaCliente)
        {

            if (listaCliente.Count >= 3)
            {
                ordenarCliente(listaCliente);

                foreach (ClienteDto cuberteria in listaCliente)
                {
                    Console.WriteLine(cuberteria.ToString());
                }
            }

            else
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Tienen que haber mínimo 3 clientes creados ");
                Console.WriteLine("---------------------------------------------");

            return listaCliente;
        }

    }
}
