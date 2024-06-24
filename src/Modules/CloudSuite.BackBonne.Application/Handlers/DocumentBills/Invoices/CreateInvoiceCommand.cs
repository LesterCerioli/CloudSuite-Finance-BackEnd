using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using CloudSuite.Modules.Commons.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices
{
    public class CreateInvoiceCommand : IRequest<CreateInvoiceResponse>
    {
    {
        public Guid Id { get; private set; }
        public string? Cnpj { get; set; }
        public string? SocialName { get; set; }
        public string? FantasyName { get; set; }
        public DateTime FundationDate { get; set; }

        public CreateCompanyCommand()
        {
            Id = Guid.NewGuid();
        }

        public CompanyEntity GetEntity()
        {
            return new CompanyEntity(
                new Cnpj(this.Cnpj),
                this.SocialName,
                this.FantasyName,
                this.FundationDate
                );
        }

    }
}
