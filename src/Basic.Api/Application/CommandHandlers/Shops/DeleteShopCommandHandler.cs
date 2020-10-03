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
    public class DeleteShopCommandHandler : CommandHandler, IRequestHandler<DeleteShopCommand, bool>
    {
        private readonly IRepository<Shop> _shopRepository;
        public DeleteShopCommandHandler(IUnitOfWork uow, IRepository<Shop> shopRepository) : base(uow)
        {
            _shopRepository = shopRepository;
        }
        public async Task<bool> Handle(DeleteShopCommand request, CancellationToken cancellationToken)
        {
            _shopRepository.Remove(request.Id);
            return await CommitAsync();
        }
    }
}
