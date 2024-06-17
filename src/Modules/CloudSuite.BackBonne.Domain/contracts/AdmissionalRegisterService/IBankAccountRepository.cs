using AdmissionalRegisterService.Model;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalEegisterService
{
    public interface IBankAccountRepository
    {
        Task<BankAccount> GetById(int id);

        Task<IEnumerable<BankAccount>> GetAll();

        Task Add(BankAccount bankAccount);

        void Update(BankAccount bankAccount);

        void Remove(BankAccount bankAccount);
    }
}