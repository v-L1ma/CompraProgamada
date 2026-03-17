using CompraProgamada.Application.Features.ClienteFeature.Commands;
using CompraProgamada.Application.Features.SampleFeature;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CompraProgamada.WebApi.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{

    private readonly IMediator _mediator;

    public ClienteController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("Produto")]
    public async Task<CreateAdesaoCommandResponse> AderirProduto([FromBody] CreateAdesaoCommand command)
    {
        CreateAdesaoCommandResponse response = await _mediator.Send(command);
        return response;
    }

    [HttpDelete("Produto")]
    public string CancelarAdesaoProduto()
    {
        return "OI";
    }

    [HttpPut("Produto/Aporte")]
    public string AlterarAporteProduto()
    {
        return "OI";
    }

    [HttpGet("Carteira")]
    public string ConsultarCarteira()
    {
        return "OI";
    }

    [HttpGet("Carteira/Rentabilidade")]
    public string ConsultarRentabilidadeCarteira()
    {
        return "OI";
    }
}