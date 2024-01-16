using EJERCICIO6OBLIGATORIO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6OBLIGATORIO.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {

        List<ClienteDto> listaCliente = new List<ClienteDto>();
        MenuInterfaz mi = new MenuImplementacion();

        public List<ClienteDto> altaCliente(List<ClienteDto> listaCliente)
        {
            ClienteDto cliente = new ClienteDto();
            cliente = crearNuevoCliente();

            listaCliente.Add(cliente);

            return listaCliente;
        }


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
        
        private List<ClienteDto> ordenarCliente(List<ClienteDto> listaCliente)
        {
            // Metodo burbuja

            for (int f = 0; f < listaCliente.Count; f++)
            {
                for (int c = 0; c < listaCliente.Count - 1 - f; c++)
                {
                    /* Intercambia las posiciones entre clientes dependiendo de la edad que tengan
                     ( cambiando el simbolo mayor que, cambiamos la condicion a cumplir )  */
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

        /*
        public List<ClienteDto> MetodoBurbuja(List<ClienteDto> listaCliente)
        {

            int edades = listaCliente.Count;

            for (int f = 0; f < listaCliente.Count; f++)
            {
                for (int c = 0; c < listaCliente.Count - 1 - f; c++)
                {
                    /* Intercambia las posiciones entre clientes dependiendo de la edad que tengan
                     ( cambiando el simbolo mayor que, cambiamos la condicion a cumplir )  */
                   /* if (listaCliente[c + 1].Edad > listaCliente[c].Edad)
                    {
                        ClienteDto aux = listaCliente[c + 1];
                        listaCliente[c + 1] = listaCliente[c];
                        listaCliente[c] = aux;
                    }

                }
            }
        
            return listaCliente;
        }*/


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
