using Empresa_client.Services;

namespace Empresa_client;

public partial class MainPage : ContentPage
{
    private readonly IEmpleadoService _service;
    public MainPage(IEmpleadoService service)
    {
        InitializeComponent();
        _service = service;
    }

    private async void CounterBtn_Clicked(object sender, EventArgs e)
    {
        esperanding.IsVisible = true;
        var lista = await _service.ListaEmpleados();
        listEmpleados.ItemsSource = lista;
        esperanding.IsVisible = false;
    }
}

