using Basic.Api.Abstractions.Enums;
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
            shop.CompanyId = request.createShopRequestDto.CompanyId;
            shop.Name = request.createShopRequestDto.Name;
            shop.ApiKey = request.createShopRequestDto.ApiKey;
            shop.ApiKeyValue = request.createShopRequestDto.ApiKeyValue;
            shop.ApiUrl = request.createShopRequestDto.ApiUrl;
            shop.AdminUrl = request.createShopRequestDto.AdminUrl;
            shop.Currency = request.createShopRequestDto.Currency;
            shop.OrderPrefix = request.createShopRequestDto.OrderPrefix;
            shop.Types=(int) request.createShopRequestDto.Types;
            shop.IsOpen = (int)request.createShopRequestDto.IsOpen;
            shop.ShareKey= request.createShopRequestDto.ShareKey;
            _shopRepository.Add(shop);
            return await CommitAsync();
        }
    }
}
