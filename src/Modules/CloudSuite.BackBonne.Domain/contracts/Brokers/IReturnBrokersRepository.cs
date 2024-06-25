using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Domain.models.Brokers;
using CloudSuite.Modules.Commons.ValueObject;

namespace CloudSuite.BackBonne.Domain.contracts.Brokers
{
    public interface IReturnBrokersRepository
    {
        Task<ReturnBrokers> GetByName(string nomeComercial);
        
        Task<ReturnBrokers> GetByCnpj(CNPJ cnpj);

        Task<IEnumerable<ReturnBrokers>> GetList();

        Task Add(ReturnBrokers returnBrokers);

        void Update(ReturnBrokers returnBrokers);
    
        void Remove(ReturnBrokers returnBrokers);
    }
}
