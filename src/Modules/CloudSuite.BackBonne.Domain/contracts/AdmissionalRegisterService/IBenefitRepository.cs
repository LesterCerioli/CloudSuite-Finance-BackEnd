using AdmissionalRegisterService.Model;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalEegisterService
{
    public interface IBenefitRepository
    {
        Task<Benefit> GetById(int benefitId);

        Task<IEnumerable<Benefit>> GetAll();

        Task Add(Benefit benefit);

        void Update(Benefit benefit);

        void Remove(Benefit benefit);
    }
}