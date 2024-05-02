using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AsgardGold
{
    public interface IPasswordHasher
    {
        string? HashPassword(string password);
        Task<string> HashPasswordAsync(string password);
        bool VerifyHashedPassword(string? passwordHash, string password);
        Task<bool> VerifyHashedPasswordAsync(string hashedPassword, string providedPassword);
    }
}
