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
    public class UpdateCompanyCommandHandler : CommandHandler, IRequestHandler<UpdateCompanyCommand, bool>
    {
        private readonly IRepository<Company> _companyRepository;
        public UpdateCompanyCommandHandler(IUnitOfWork uow, IRepository<Company> companyRepository) : base(uow)
        {
            _companyRepository = companyRepository;
        }
        public async Task<bool> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var update = await _companyRepository.GetByIdAsync(request.updateCompanyRequestDto.Id);
            update.Name = request.updateCompanyRequestDto.Name;
            update.SkuPrefix= request.updateCompanyRequestDto.SkuPrefix;
            update.AdditionalFee = request.updateCompanyRequestDto.AdditionalFee;
            _companyRepository.Update(update);
            return await CommitAsync();
        }
    }
}
