using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6OBLIGATORIO.Dtos
{
    internal class ClienteDto
    {
        /*
        El dto cliente contendrá los siguientes campos:
        - idCliente int64
        - nombreCliente texto
        - apellidosCliente texto
        - nombreCompletoCliente texto
        - edad int32
        */

        // Atributos

        long idCliente;
        string nombreCliente = "aaaaaa";
        string apellidosCliente = "aaaaaa";
        string nombreCompletoCliente = "aaaaaa";
        int edad = 0;


        // Getter y Setter

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }


        // Constructores

        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompletoCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.edad = edad;
        }

        public ClienteDto() { }


        override
        public string ToString()
        {
            string clienteString = "Nombre y apellidos: " + this.nombreCompletoCliente + " | " +
                "Edad: " + this.edad;


            return clienteString;

        }

    }
}
