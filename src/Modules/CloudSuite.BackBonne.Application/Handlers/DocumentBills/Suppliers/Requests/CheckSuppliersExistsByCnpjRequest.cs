using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Responses;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Requests
{
    public class CheckSuppliersExistsByCnpjRequest : IRequest<CheckSuppliersExistsByCnpjResponse>
    {
        public Guid Id {  get; private set; }
        public string Cnpj {  get;  set; }

        public CheckSuppliersExistsByCnpjRequest(string cnpj)
        {
            Id = Guid.NewGuid();
            Cnpj = cnpj;
        }
    }
}
