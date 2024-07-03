using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CloudSuite.BackBonne.Application.Handlers.AdviceService;
using CloudSuite.BackBonne.Application.Services.Contracts;
using CloudSuite.BackBonne.Application.ViewModels;
using CloudSuite.BackBonne.Domain.contracts;
using CloudSuite.BackBonne.Domain.models.AdviceService;
using NetDevPack.Mediator;

namespace CloudSuite.BackBonne.Application.Services.Implementations
{
    public class InvestmentAppService : IInvestmentAppService
    {
        private readonly IInvestmentRepository _investmentRepository;
        private readonly IMediatorHandler _mediator;
        private readonly IMapper _mapper;

        public InvestmentAppService(
            IInvestmentRepository investmentRepository,
            IMediatorHandler mediator,
            IMapper mapper)
        {
            _investmentRepository = investmentRepository;
            _mediator = mediator;
            _mapper = mapper;

        }

        public async Task<InvestmentViewModel> GetByTaxPayerRegistry(string taxPayerRegistry)
        {
            return _mapper.Map<InvestmentViewModel>(await _investmentRepository.GetByTaxPayerRegistry(taxPayerRegistry));
        }

        public async Task<InvestmentViewModel> GetByName(string name)
        {
            return _mapper.Map<InvestmentViewModel>(await _investmentRepository.GetByName(name));
        }

        public async Task<InvestmentViewModel> GetByInvestmentProfile(string investmentProfile)
        {
            return _mapper.Map<InvestmentViewModel>(await _investmentRepository.GetByInvestmentProfile(investmentProfile));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task Save(CreateInvestmentCommand createCommand)
        {
            await _investmentRepository.Add(createCommand.GetEntity());
        }
    }
}
