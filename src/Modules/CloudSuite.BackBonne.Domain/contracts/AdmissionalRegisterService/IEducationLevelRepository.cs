using AdmissionalRegisterService.Model;
using CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IEducationLevelRepository
    {
        Task<EducationLevel> GetByDescriptionCommons(DescriptionCommons descriptionCommons);
        Task<IEnumerable<EducationLevel>> GetAList();

        Task Add(EducationLevel educationLevel);

        void Update(EducationLevel educationLevel);

        void Remove(EducationLevel educationLevel);
    }
}    