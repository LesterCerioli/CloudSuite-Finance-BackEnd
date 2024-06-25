using CloudSuite.BackBonne.Domain.models.AsgardGold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AsgardGold
{
    public interface IUserClaimRepository
    {
        Task<UserClaim> GetByType(string type);

        Task<IEnumerable<UserClaim>> GetList();

        Task Add(UserClaim userClaim);

        void Update(UserClaim userClaim);

        void Remove(UserClaim userClaim);
    }
}
