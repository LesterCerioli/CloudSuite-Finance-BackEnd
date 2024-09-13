using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.Administration
{
    public interface IEducationLevelRepository
    {
        Task<EducationLevel> GetByEducationLevelName(string? ducationLevelName);

        Task<IEnumerable<EducationLevel>> GetList();

        Task Add(EducationLevel educationLevel);

        void Update(EducationLevel educationLevel);

        void Remove(EducationLevel educationLevel);
         
    }
}