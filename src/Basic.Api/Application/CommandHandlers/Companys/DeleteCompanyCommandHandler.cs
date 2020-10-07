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
    public class DeleteCompanyCommandHandler : CommandHandler, IRequestHandler<DeleteCompanyCommand, bool>
    {
        private readonly IRepository<Company> _companyRepository;
        public DeleteCompanyCommandHandler(IUnitOfWork uow, IRepository<Company> companyRepository) : base(uow)
        {
            _companyRepository = companyRepository;
        }
        public async Task<bool> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            _companyRepository.Remove(request.Id);
            return await CommitAsync();
        }
    }
}
