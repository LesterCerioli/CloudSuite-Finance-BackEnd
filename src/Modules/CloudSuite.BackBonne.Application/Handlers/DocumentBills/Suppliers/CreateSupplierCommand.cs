using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Responses;
using CloudSuite.Modules.Common.Valueobjects;
using MediatR;
using SupplierEntity = CloudSuite.BackBonne.Domain.models.DownloadBills.Supplier;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers
{
    public class CreateSupplierCommand : IRequest<CreateSuppliersResponse>
    {
        public Guid Id { get; private set; }

        public string? Cnpj { get; set; }

        public string? SupplierName { get; set; }

        public CreateSupplierCommand()
        {
            Id = Guid.NewGuid();
        }

        public SupplierEntity GetEntity()
        {
            return new SupplierEntity(
                this.SupplierName,
                new Cnpj(this.Cnpj)
                );
        }
    }
}
