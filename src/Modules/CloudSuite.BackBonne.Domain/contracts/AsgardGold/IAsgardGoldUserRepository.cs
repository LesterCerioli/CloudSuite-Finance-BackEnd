using CloudSuite.BackBonne.Domain.models.AsgardGold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AsgardGold
{
    public interface IAsgardGoldUserRepository
    {
        Task<AsgardGoldUser> GetByEmail(string email);

        Task<IEnumerable<AsgardGoldUser>> GetList();

        Task Add(AsgardGoldUser asgardGoldUser);

        void Update(AsgardGoldUser asgardGoldUser);

        void Remove(AsgardGoldUser asgardGoldUser);
    }
}
