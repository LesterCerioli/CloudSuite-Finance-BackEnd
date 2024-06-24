using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Responses;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Requests
{
    public class CheckSuppliersExistsBySupplierNameRequest : IRequest<CheckSuppliersExistsBySupplierNameResponse>
    {
        public Guid Id {  get; private set; }
        public string SupplierName { get; set; }

        public CheckSuppliersExistsBySupplierNameRequest(string supplierName)
        {
            Id = Guid.NewGuid();
            SupplierName = supplierName;
        }
    }
}
