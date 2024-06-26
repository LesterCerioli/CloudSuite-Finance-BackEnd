using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.Modules.Commons.ValueObject;
using Newtonsoft.Json;

namespace CloudSuite.BackBonne.Application.JsonConversor.Brokers
{
    public class BuscaPorCorretora
    {
        [JsonProperty("cnpj")]
        public CNPJ Cnpj { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("nome_social")]
        public string NomeSocial { get; set; }

        [JsonProperty("nome_comercial")]
        public string NomeComercial { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telefone")]
        public string Telefone { get; set; }

        [JsonProperty("cep")]
        public CEP Cep { get; set; }

        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("data_patrimonio_liquido")]
        public DateTime DataPatrimonioLiquido { get; set; }

        [JsonProperty("valor_patrimonio_liquido")]
        public decimal ValorPatrimonioLiquido { get; set; }

        [JsonProperty("codigo_cvm")]
        public string CodigoCvm { get; set; }

        [JsonProperty("data_inicio_situacao")]
        public DateTime DataInicioSituacao { get; set; }

        [JsonProperty("data_registro")]
        public DateTime DataRegistro { get; set; }
    }
}
