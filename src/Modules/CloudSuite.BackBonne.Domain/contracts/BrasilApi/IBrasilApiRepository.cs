using CloudSuite.BackBonne.Domain.models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.BrasilApi
{
    internal interface IBrasilApiRepository
    {   
        
        Task<ResponseGenerico<List<Broker>>> SourchBroker