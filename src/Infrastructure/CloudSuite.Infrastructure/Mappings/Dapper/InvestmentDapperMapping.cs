using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Domain.models.AdviceService;

namespace CloudSuite.Infrastructure.Data.Mappings.Dapper.Cora
{
    public class InvestmentDapperMapping
    {
        private readonly IDbConnection _connection;

        public InvestmentDapperMapping(IDbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public async Task<IEnumerable<Investment>> GetAllInvestmentsAsync()
        {
            var query = @"
                        SELECT
                            taxPayerRegistry as TaxPayerRegistry,
                            name as Name,
                            investmentProfile as InvestmentProfile,
                        FROM
                            msfinance_investments";

            return await _connection.QueryAsync<Investment>(query);
        }

        public async Task<Investment> GetInvestmentByTaxPayerRegistryAsync(string taxPayerRegistry)
        {
            var query = @"
                        SELECT
                            taxPayerRegistry as TaxPayerRegistry,
                        FROM
                            msfinance_investments
                        WHERE
                            taxPayerRegistry = @InvestmentTaxPayerRegistry";

            return await _connection.QueryFirstOrDefaultAsync<Investment>(query, new { TaxPayerRegistry = taxPayerRegistry });
        }

        public async Task<Investment> GetInvestmentByNameAsync(string name)
        {
            var query = @"
                        SELECT
                            name as Name,
                        FROM
                            msfinance_investments
                        WHERE
                            name = @InvestmentName";

            return await _connection.QueryFirstOrDefaultAsync<Investment>(query, new { Name = name });
        }

        public async Task<Investment> GetInvestmentByInvestmentProfileAsync(string investmentProfile)
        {
            var query = @"
                        SELECT
                            investmentProfile as InvestmentProfile,
                        FROM
                            msfinance_investments
                        WHERE
                            investmentProfile = @InvestmentInvestmentProfile";

            return await _connection.QueryFirstOrDefaultAsync<Investment>(query, new { InvestmentProfile = investmentProfile });
        }
    }
}
