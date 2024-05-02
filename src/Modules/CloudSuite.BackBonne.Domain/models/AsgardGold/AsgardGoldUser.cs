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
            _userClaims = new List<UserClaim>();
        }

        public string? Email { get; private set; }

        public string? PasswordHash { get; private set; }

        private readonly List<UserClaim> _userClaims;

        public UserClaim UserClaim { get; private set; }

        public IReadOnlyCollection<UserClaim> UserClaims => _userClaims.AsReadOnly();

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
