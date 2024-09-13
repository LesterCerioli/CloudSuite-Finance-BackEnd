using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Backbonne
{
    public class UserBackBonne : Entity, IAggregateRoot
    {
        public UserBackBonne(string? login, int? companyId, string? token, string? photoURI)
        {
            Login = login;
            CompanyId = companyId;
            Token = token;
            PhotoURI = photoURI;
        }

        public string? Login { get; private set; }

        public int? CompanyId { get; private set; }

        public string? Token { get; private set; }

        public string? PhotoURI { get; private set; }
    }
}
