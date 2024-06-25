using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Domain.models.Brokers;
using CloudSuite.Modules.Commons.ValueObject;

namespace CloudSuite.BackBonne.Domain.contracts.Brokers
{
    public interface ISearchBrokersRepository
    {
        Task<SearchBrokers> GetByCnpj(CNPJ cnpj);

        Task<IEnumerable<SearchBrokers>> GetList();

        Task Add(SearchBrokers searchBrokers);

        void Update(SearchBrokers searchBrokers);

        void Remove(SearchBrokers searchBrokers);
    }
}
