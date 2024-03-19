using E_Nak.Application.Repositories.Write.Account;
using MediatR;

namespace E_Nak.Application.Features.Commands.Account.CreateProducer
{
    public class CreateProducerCommandHandler : IRequestHandler<CreateProducerCommandRequest, CreateProducerCommandResponse>
    {
        readonly IProducerWriteRepository _repository;

        public CreateProducerCommandHandler(IProducerWriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateProducerCommandResponse> Handle(CreateProducerCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new()
            {
                ProducerName = request.ProducerName,
                Phone = request.Phone,
                BillingAddress = request.BillingAddress,
                City = request.City,
                Country = request.Country,
                District = request.District,
                Email = request.Email,
                Fax = request.Fax,
                TaxAdministrator = request.TaxAdministrator,
                TaxNumber = request.TaxNumber,
                IsActive = request.IsActive,
            });
            await _repository.SaveAsync();
            return new();
        }
    }
}
