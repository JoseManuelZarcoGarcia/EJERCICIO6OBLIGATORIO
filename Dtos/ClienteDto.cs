using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6OBLIGATORIO.Dtos
{
    /// <summary>
    /// Clase que contiene la entidad Cliente
    /// 160124 - jzg
    /// </summary>
    internal class ClienteDto
    {

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

        /// <summary>
        /// Metodo para escribir por pantalla los atributos definidos del objeto
        /// 170124 - jzg
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            string clienteString = "Nombre y apellidos: " + this.nombreCompletoCliente + " | " +
                "Edad: " + this.edad;


            return clienteString;

        }

    }
}
