using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Backbonne
{
    public class Credential : Entity, IAggregateRoot
    {
        public Credential(string? password, string? iPAddress)
        {
            Password = password;
            IPAddress = iPAddress;
            _userBackBonnes = new List<UserBackBonne>();
        }

        public UserBackBonne UserBackBonne { get; private set; }

        public IReadOnlyCollection<UserBackBonne> UserBackBonnes => _userBackBonnes.AsReadOnly();
        
        public string? Password { get; private set; }

        
        public string? IPAddress { get; private set; }

        private readonly List<UserBackBonne> _userBackBonnes;
    }
}
