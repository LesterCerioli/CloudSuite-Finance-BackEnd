using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Domain.models.Brokers;
using CloudSuite.Modules.Commons.ValueObjects;

namespace CloudSuite.BackBonne.Domain.contracts.Brokers
{
    public interface IBrokerRepository
    {
        Task<Broker> GetByName(string nomeComercial);
        
        Task<Broker> GetByCnpj(Cnpj cnpj);

        Task<IEnumerable<Broker>> GetList();

        Task Add(Broker returnBrokers);

        void Update(Broker returnBrokers);
    
        void Remove(Broker returnBrokers);
    }
}
