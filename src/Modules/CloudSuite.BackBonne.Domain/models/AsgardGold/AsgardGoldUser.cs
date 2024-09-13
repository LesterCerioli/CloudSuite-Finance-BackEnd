using CloudSuite.BackBonne.Domain.contracts.AsgardGold;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AsgardGold
{
    public class AsgardGoldUser : Entity, IAggregateRoot
    {
        public AsgardGoldUser(string? email, string? passwordHash)
        {
            Email = email;
            PasswordHash = passwordHash;
            
        }

        public string? Email { get; private set; }

        public string? PasswordHash { get; private set; }

        

        public void SetPassword(string password, IPasswordHasher hasher)
        {
            PasswordHash = hasher.HashPassword(password);
        }

        public bool ValidatePassword(string password, IPasswordHasher hasher)
        {
            return hasher.VerifyHashedPassword(PasswordHash, password);
        }

    }
}
