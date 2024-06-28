using AdmissionalRegisterService.Model;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IEducationLevelRepository
    {
        Task<EducationLevel> GetById(int educationLevelId);

        Task<IEnumerable<EducationLevel>> GetAll();

        Task Add(EducationLevel educationLevel);

        void Update(EducationLevel educationLevel);

        void Remove(EducationLevel educationLevel);
    }
}  