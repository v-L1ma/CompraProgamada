using Microsoft.AspNetCore.Mvc;

namespace CompraProgamada.WebApi.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    [HttpPost("Cesta")]
    public string CadastrarCesta()
    {
        return "OI";
    }

    [HttpGet("Cesta")]
    public string VizualizarCestaAtual()
    {
        return "OI";
    }

    [HttpPost("Cesta/Historico")]
    public string HistoricoCestas()
    {
        return "OI";
    }


}