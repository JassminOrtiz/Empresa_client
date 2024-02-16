using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_client.DTOs;
public class EmpleadoDTO
{
    public string? ID_Empleado { get; set; }
    public string? nombre { get; set; }
    public string? apellido_paterno { get; set; }
    public string? apellido_materno { get; set; }
    public string? ID_Estado { get; set; }
    public string? Estado { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool Active { get; set; }

}
