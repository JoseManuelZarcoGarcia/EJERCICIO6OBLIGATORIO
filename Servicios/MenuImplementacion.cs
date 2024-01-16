using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6OBLIGATORIO.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Crear nuevo cliente");
            Console.WriteLine("2. Ordenar clietes");
            Console.WriteLine("---------------------------------------------");


            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }

    }
}
