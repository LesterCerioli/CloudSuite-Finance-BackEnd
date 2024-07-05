using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.Modules.Commons.ValueObjects;

namespace CloudSuite.BackBonne.Domain.models.BaixaContaReceber
{
    public class TEDItem : Entity, IAggregateRoot
    {
        public string? Hash { get; private set; }

        public DateTimeOffset? DataHoraIntegradao { get; private set; }

        public DateTimeOffset? DataHoraOperacao { get; set; }

        public string? DataLancamento { get; private set; }

        public string? Valor { get; private set; }
        
        public string? Tipo { get; private set; }

        public string? TipoPessoaContraparte { get; private set; }

        public string? NomeClienteContraparte { get; private set; }

        public string? IspbContraparte { get; private set; }

        public Cnpj Cnpj { get; private set; }

        public string? codBancoContraparte { get; private set; }

        public string? NomeBancoContraparte { get; private set; }

        public string? AgenciaContraparte { get; private set; }

        public string? NumContaContraparte { get; private set; }


        public IReadOnly<Branch> Bramch => _branches.AsReadOnly();

        public Bank Bank { get; private set; }

        public Branch Branch { get; private set; }

        public Account Account { get; private set; }

    }
}