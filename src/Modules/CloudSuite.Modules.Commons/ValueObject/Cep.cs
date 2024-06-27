using System;
using System.Text.RegularExpressions;
using NetDevPack.Domain;

namespace CloudSuite.Modules.Commons.ValueObject
{
    public class CEP : NetDevPack.Domain.ValueObject
    {
        public string Cep { get; private set; }

        public string State { get; private set; }

        public string City { get; private set; }

        public string Neighborhood { get; private set; }

        public string Street { get; private set; }

        public string Service { get; private set; }

        public void SetCep(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
                throw new ArgumentException("CEP não pode ser vazio.");

            var cepRegex = new Regex(@"^\d{5}-\d{3}$");

            if (!cepRegex.IsMatch(cep))
                throw new ArgumentException("Formato de CEP inválido. O CEP deve estar no formato xxxxx-xxx.");

            Cep = cep;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}