using System.Net;
using CompraProgamada.Application.Abstractions.Messaging;
using CompraProgamada.Application.Features.SampleFeature;
using CompraProgamada.Application.Repositories;
using CompraProgamada.Domain.Entities;
using CompraProgamada.Domain.Entities.ClienteEntity;
using CompraProgamada.Domain.Exceptions;

namespace CompraProgamada.Application.Features.ClienteFeature.Commands
{
    public sealed class CreateAdesaoCommandHandler : ICommandHandler<CreateAdesaoCommand, CreateAdesaoCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateAdesaoCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateAdesaoCommandResponse> Handle(CreateAdesaoCommand request, CancellationToken cancellationToken)
        {
            if (ValidarCampos(request))
            {
                throw new DomainException("CAMPOS_INVALIDOS", "Informe todos os campos.", (int)HttpStatusCode.BadRequest);
            }

            if(request.ValorMensal < 100)
            {
                throw new DomainException("VALOR_MENSAL_INVALIDO", "O valor mensal minimo e de R$ 100,00.", (int)HttpStatusCode.BadRequest);
            }

            var clienteRepository = _unitOfWork.GetRepository<Cliente>();

            if (clienteRepository.GetAllAsync().Result.FirstOrDefault(c => c.CPF == request.CPF) != null)
            {
                throw new DomainException("CLIENTE_CPF_DUPLICADO", "CPF ja cadastrado no sistema.", (int)HttpStatusCode.BadRequest);
            }
            
            var cliente = new Cliente
            {
                Nome = request.Nome,
                CPF = request.CPF,
                Email = request.Email,
                ValorMensal = request.ValorMensal,
                Ativo = true,
                DataAdesao = DateTime.UtcNow
            };
            
            var clienteCadastrado = await clienteRepository.AddAsync(cliente);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            var contaGraficaRepository = _unitOfWork.GetRepository<ContaGrafica>();

            int qtdClientes = clienteRepository.GetAllAsync().Result.ToList().Count;

            string NumeroConta = $"FLH-{qtdClientes.ToString().PadLeft(6,'0')}";

            var contaGraficaFilhote = new ContaGrafica
            {
                ClienteId = clienteCadastrado.Id,
                NumeroConta = NumeroConta,
                Tipo = Domain.Enums.TipoConta.Filhote,
                DataCriacao = DateTime.UtcNow
            };

            var contaGraficaCriada = await contaGraficaRepository.AddAsync(contaGraficaFilhote);

            CreateAdesaoCommandResponse response = new CreateAdesaoCommandResponse
            (
                clienteCadastrado.Id,
                clienteCadastrado.Nome,
                clienteCadastrado.CPF,
                clienteCadastrado.Email,
                clienteCadastrado.ValorMensal,
                clienteCadastrado.Ativo,
                clienteCadastrado.DataAdesao,
                new ContaGraficaResponse(
                    contaGraficaCriada.Id,
                    contaGraficaCriada.NumeroConta,
                    contaGraficaCriada.Tipo.ToString(),
                    contaGraficaCriada.DataCriacao
                )
            );

            return response;
        }
        private static bool ValidarCampos(CreateAdesaoCommand request)
        {
            return string.IsNullOrWhiteSpace(request.Nome) ||
                string.IsNullOrWhiteSpace(request.CPF) ||
                string.IsNullOrWhiteSpace(request.Email);
        }  

    }
}