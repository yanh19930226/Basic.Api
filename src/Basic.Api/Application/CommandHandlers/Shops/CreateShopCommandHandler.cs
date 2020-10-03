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
    public class CreateShopCommandHandler : CommandHandler, IRequestHandler<CreateShopCommand, bool>
    {
        private readonly IRepository<Shop> _shopRepository;
        public CreateShopCommandHandler(IUnitOfWork uow, IRepository<Shop> shopRepository) : base(uow)
        {
            _shopRepository = shopRepository;
        }
        public async Task<bool> Handle(CreateShopCommand request, CancellationToken cancellationToken)
        {
            Shop shop = new Shop();
            shop.Name = request.createShopDto.Name;
            //shop.SkuPrefix = request.SkuPrefix;
            //shop.AdditionalFee = request.AdditionalFee;
            _shopRepository.Add(shop);
            return await CommitAsync();
        }
    }
}
