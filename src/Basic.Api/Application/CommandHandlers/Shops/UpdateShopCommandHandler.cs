using Basic.Api.Application.Commands.Shops;
using Basic.Api.Models.Domain;
using Core.Data.Domain.CommandHandlers;
using Core.Data.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Basic.Api.Application.CommandHandlers.Shops
{
    public class UpdateShopCommandHandler : CommandHandler, IRequestHandler<UpdateShopCommand, bool>
    {
        private readonly IRepository<Shop> _shopRepository;
        public UpdateShopCommandHandler(IUnitOfWork uow, IRepository<Shop> shopRepository) : base(uow)
        {
            _shopRepository = shopRepository;
        }
        public async Task<bool> Handle(UpdateShopCommand request, CancellationToken cancellationToken)
        {
            var update = await _shopRepository.GetByIdAsync(request.updateShopRequestDto.Id);
            update.Name = request.updateShopRequestDto.Name;
            //update.SkuPrefix = request.updateCompanyDto.SkuPrefix;
            //update.AdditionalFee = request.updateCompanyDto.AdditionalFee;
            _shopRepository.Update(update);
            return await CommitAsync();
        }
    }
}
