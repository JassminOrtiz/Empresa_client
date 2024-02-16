using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Empresa_client.DTOs;

namespace Empresa_client.Services;
public class EmpleadoService : IEmpleadoService
{
    private string apiurl = "https://localhost:7237/GET_Empleados";


    async Task<List<EmpleadoDTO>> IEmpleadoService.ListaEmpleados()
    {
        List<EmpleadoDTO> empleadoDTOs = new List<EmpleadoDTO>();
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(apiurl);
        client.Timeout = TimeSpan.FromSeconds(30);
        HttpResponseMessage httpresponse = await client.PostAsync(apiurl, null);
        if (httpresponse.IsSuccessStatusCode)
        {
            string conte = await httpresponse.Content.ReadAsStringAsync();
            #pragma warning disable CS8600
            empleadoDTOs = JsonSerializer.Deserialize<List<EmpleadoDTO>>(conte);
            #pragma warning restore CS8600
        }

        #pragma warning disable CS8604
        return await Task.FromResult(empleadoDTOs.ToList());
        #pragma warning restore CS8604
    }
}
