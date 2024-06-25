using System;
using System.Collections.Generic;
using NetDevPack.Domain;

namespace CloudSuite.Modules.Commons.ValueObject
{
    public class CNPJ : NetDevPack.Domain.ValueObject
    {
        public string Cnpj { get; set; }

        public int IdentificadorMatrizFilial { get; set; }

        public string DescricaoMatrizFilial { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public int SituacaoCadastral { get; set; }

        public string DescricaoSituacaoCadastral { get; set; }

        public DateTime DataSituacaoCadastral { get; set; }

        public int MotivoSituacaoCadastral { get; set; }

        public string NomeCidadeExterior { get; set; }

        public int CodigoNaturezaJuridica { get; set; }

        public DateTime DataInicioAtividade { get; set; }

        public int CnaeFiscal { get; set; }

        public string CnaeFiscalDescricao { get; set; }

        public string DescricaoTipoDeLogradouro { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public int Cep { get; set; }

        public string Uf { get; set; }

        public int CodigoMunicipio { get; set; }

        public string Municipio { get; set; }

        public string DddTelefone1 { get; set; }

        public string DddTelefone2 { get; set; }

        public string DddFax { get; set; }

        public int QualificacaoDoResponsavel { get; set; }

        public int CapitalSocial { get; set; }

        public int Porte { get; set; }

        public string DescricaoPorte { get; set; }

        public bool OpcaoPeloSimples { get; set; }

        public DateTime? DataOpcaoPeloSimples { get; set; }

        public DateTime? DataExclusaoDoSimples { get; set; }

        public bool OpcaoPeloMei { get; set; }

        public string SituacaoEspecial { get; set; }

        public DateTime? DataSituacaoEspecial { get; set; }

        public List<CNAESecundario> CNAESecundarios { get; set; }

        public List<QSA> QsaList { get; set; }

        public class CNAESecundario
        {
            public int Codigo { get; set; }

            public string Descricao { get; set; }
        }

        public class QSA
        {
            public int IdentificadorDeSocio { get; set; }

            public string NomeSocio { get; set; }

            public string CnpjCpfDoSocio { get; set; }

            public int CodigoQualificacaoSocio { get; set; }

            public int PercentualCapitalSocial { get; set; }

            public DateTime DataEntradaSociedade { get; set; }

            public string CpfRepresentanteLegal { get; set; }

            public string NomeRepresentanteLegal { get; set; }

            public int? CodigoQualificacaoRepresentanteLegal { get; set; }
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}