using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.Modules.Common.ValueObjects;
using NetDevPack.Domain;

namespace CloudSuite.BackBonne.Domain.models.Brokers
{
    public class Broker : Entity, IAggregateRoot
    {
        public Broker(string bairro, Cep cep, Cnpj cnpj, string codigoCvm, string complemento, DateTime dataInicioSituacao, 
            DateTime dataPatrimonioLiquido, DateTime dataRegistro, string email, string logradouro, string municipio, string nomeSocial, 
            string nomeComercial, string pais, string status, string telefone, string type, string uf, decimal valorPatrimonioLiquido)
        {
            Bairro = bairro;
            Cep = cep;
            Cnpj = cnpj;
            CodigoCvm = codigoCvm;
            Complemento = complemento;
            DataInicioSituacao = dataInicioSituacao;
            DataPatrimonioLiquido = dataPatrimonioLiquido;
            DataRegistro = dataRegistro;
            Email = email;
            Logradouro = logradouro;
            Municipio = municipio;
            NomeSocial = nomeSocial;
            NomeComercial = nomeComercial;
            Pais = pais;
            Status = status;
            Telefone = telefone;
            Type = type;
            Uf = uf;
            ValorPatrimonioLiquido = valorPatrimonioLiquido;
        }
     
        public Broker() { }

        public string? Bairro { get; private set; }

        public Cep Cep { get; private set; }

        public Cnpj Cnpj { get; private set; }

        public string? CodigoCvm { get; private set; }

        public string? Complemento { get; private set; }

        public DateTime? DataInicioSituacao { get; private set; }

        public DateTime? DataPatrimonioLiquido { get; private set; }

        public DateTime? DataRegistro { get; private set; }

        public string? Email { get; private set; }

        public string? Logradouro { get; private set; }

        public string? Municipio { get; private set; }

        public string? NomeSocial { get; private set; }

        public string? NomeComercial { get; private set; }

        public string? Pais { get; private set; }

        public string? Status { get; private set; }

        public string? Telefone { get; private set; }

        public string? Type { get; private set; }

        public string? Uf { get; private set; }

        public decimal? ValorPatrimonioLiquido { get; private set; }
    }
}