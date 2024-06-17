using System.Collections.Generic;
using System.Threading.Tasks;
using AdmissionalRegisterService.Model;
using CloudSuite.Domain.Models;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalEegisterService
{
    public interface ICourseRepository
    {
        Task<Course> GetById(int courseId);

        Task<IEnumerable<Course>> GetAll();

        Task Add(Course course);

        void Update(Course course);

        void Remove(Course course);
    }
}