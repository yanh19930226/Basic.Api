using Basic.Api.Application.Commands.Companys;
using Basic.Api.Models.Domain;
using Core.Data.Domain.CommandHandlers;
using Core.Data.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Basic.Api.Application.CommandHandlers.Comapanys
{
    public class CreateCompanyCommandHandler : CommandHandler, IRequestHandler<CreateCompanyCommand, bool>
    {
        private readonly IRepository<Company> _companyRepository;
        public CreateCompanyCommandHandler(IUnitOfWork uow, IRepository<Company> companyRepository) : base(uow)
        {
            _companyRepository = companyRepository;
        }
        public async Task<bool> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            Company company = new Company();
            company.Name = request.Name;
            company.SkuPrefix = request.SkuPrefix;
            company.AdditionalFee = request.AdditionalFee;
            _companyRepository.Add(company);
            return await CommitAsync();
        }
    }
}
