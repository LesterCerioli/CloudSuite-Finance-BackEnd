
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NetDevPack.Domain;

namespace CloudSuite.Modules.Commons.ValueObjects
{
    public class Cpf : ValueObject
    {
        public string CpfExpression { get; private set; }

        public Cpf(string cpfNumber)
        {
            SetCep(cpfNumber);
        }

        public void SetCep(string cpfNumber)
        {
            // Check if the provided CPF number is valid
            if (!isValid(cpfNumber))
                throw new ArgumentException("Invalid CNPJ Number", nameof(cpfNumber));

            // Set the CNPJ number if it's valid
            CpfExpression = cpfNumber;
        }

        public bool isValid(string cpf)
        {
            // Define a expressão regular para o formato XXX.XXX.XXX-XX
            string pattern = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";

            // Cria um objeto Regex com o padrão
            Regex regex = new Regex(pattern);

            // Verifica se o CPF fornecido corresponde ao padrão
            if (!regex.IsMatch(cpf))
            {
                return false;
            }

            // Remove os caracteres de pontuação
            cpf = cpf.Replace(".", "").Replace("-", "");

            // Verifica se todos os dígitos são iguais (ex.: 111.111.111-11)
            if (new string(cpf[0], cpf.Length) == cpf)
            {
                return false;
            }

            // Calcula os dígitos verificadores
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            // Verifica se os dígitos verificadores são iguais aos informados
            return cpf.EndsWith(digito);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
