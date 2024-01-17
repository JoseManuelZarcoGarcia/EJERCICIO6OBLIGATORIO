using EJERCICIO6OBLIGATORIO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6OBLIGATORIO.Servicios
{

    /// <summary>
    /// Interfaz que implementa los metodos de clientes
    /// 160124 - jzg
    /// </summary>
    internal interface ClienteInterfaz
    {

        public List<ClienteDto> altaCliente(List<ClienteDto> listaCliente);

        public List<ClienteDto> validarOrdenarCliente(List<ClienteDto> listaCliente);

    }
}
