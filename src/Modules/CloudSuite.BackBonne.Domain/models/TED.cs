using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models
{
    public class TED : Entity, IAggregateRoot
    {
        public TED(string? hash, DateTimeOffset? dataHoraIntegradao, DateTimeOffset? dataHoraOperacao, DateTime? dataLancamento, string? valor, string? tipo, string? tipoPessoaContraparte, string? nomeClienteContraparte, string? ispbContraparte, string? cpfContraparte, string? cnpjContraparte, string? codBancoContraparte, string? nomeBancoContraparte, string? agenciaContraparte, string? numContaContraparte)
        {
            Hash = hash;
            DataHoraIntegradao = dataHoraIntegradao;
            DataHoraOperacao = dataHoraOperacao;
            DataLancamento = dataLancamento;
            Valor = valor;
            Tipo = tipo;
            TipoPessoaContraparte = tipoPessoaContraparte;
            NomeClienteContraparte = nomeClienteContraparte;
            IspbContraparte = ispbContraparte;
            CpfContraparte = cpfContraparte;
            CnpjContraparte = cnpjContraparte;
            CodBancoContraparte = codBancoContraparte;
            NomeBancoContraparte = nomeBancoContraparte;
            AgenciaContraparte = agenciaContraparte;
            NumContaContraparte = numContaContraparte;
            _dataBanks = new List<DataBank>();
        }

        public string? Hash { get; private set; }

        public DateTimeOffset? DataHoraIntegradao { get; private set; }

        public DateTimeOffset? DataHoraOperacao { get; private set; }

        public DateTime? DataLancamento { get; private set; }

        public string? Valor { get; private set; }

        public string? Tipo { get; private set; }

        public string? TipoPessoaContraparte { get; private set; }

        public string? NomeClienteContraparte { get; private set; }

        public string? IspbContraparte { get; private set; }

        public string? CpfContraparte { get; private set; }

        public string? CnpjContraparte { get; private set; }

        public string? CodBancoContraparte { get; private set; }

        public string? NomeBancoContraparte { get; private set; }

        public string? AgenciaContraparte { get; private set; }

        public string? NumContaContraparte { get; private set; }

        private readonly List<DataBank> _dataBanks;

        public DataBank DataBank { get; private set; }

        public IReadOnlyCollection<DataBank> DataBanks => _dataBanks.AsReadOnly();
    }
}
