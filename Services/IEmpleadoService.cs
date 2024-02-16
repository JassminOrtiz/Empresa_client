using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_client.DTOs;

namespace Empresa_client.Services;
public interface IEmpleadoService
{
    public Task<List<EmpleadoDTO>> ListaEmpleados();
}
