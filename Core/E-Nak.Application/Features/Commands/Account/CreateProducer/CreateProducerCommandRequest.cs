using MediatR;

namespace E_Nak.Application.Features.Commands.Account.CreateProducer
{
    public class CreateProducerCommandRequest : IRequest<CreateProducerCommandResponse>
    {
        public string ProducerName { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? BillingAddress { get; set; }
        public string? TaxNumber { get; set; }
        public string? TaxAdministrator { get; set; }
        public bool IsActive { get; set; }

    }
}
