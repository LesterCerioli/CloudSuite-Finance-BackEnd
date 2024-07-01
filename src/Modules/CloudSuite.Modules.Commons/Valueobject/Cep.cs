using NetDevPack.Domain;
using System.Text.RegularExpressions;

namespace CloudSuite.Modules.Common.Valueobject
{
    public class Cep : ValueObject
    {

        private string _cepExpression;

        public Cep(string? cep)
        {
            SetCep(cep);
        }

        //Propriedade de Acesso ao CEP
        public string cep => _cepExpression;

        private void SetCep(string cep)
        {
            // Check if the provided CEP number is valid
            if (!isValid(cep))
                throw new ArgumentException("Invalid CEP Format", nameof(cep));

            // Set the CEP number if it's valid
            _cepExpression = cep;
        }


        public bool isValid(string cep)
        {
            // Define a expressão regular para o formato XXXXX-XXX
            string pattern = @"^\d{5}-\d{3}$";

            // Cria um objeto Regex com o padrão
            Regex regex = new Regex(pattern);

            // Retorna se o CEP fornecido corresponde ao padrão
            return regex.IsMatch(cep);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
