using System;
using System.Text.RegularExpressions;
using NetDevPack.Domain;

namespace CloudSuite.Modules.Common.ValueObjects
{
    public class Cep : ValueObject
    {
        public string CepNumber { get; private set; }

        public Cep(string cepNumber)
        {
           SetCep(cepNumber);
        }

        public void SetCep(string cepNumber)
        {
            if (string.IsNullOrWhiteSpace(cepNumber))
                throw new ArgumentException("CEP não pode ser vazio.");

            var cepRegex = new Regex(@"^\d{5}-\d{3}$");

            if (!cepRegex.IsMatch(cepNumber))
                throw new ArgumentException("Formato de CEP inválido. O CEP deve estar no formato xxxxx-xxx.");

            CepNumber = cepNumber;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}