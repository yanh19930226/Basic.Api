using Basic.Api.Application.Commands.Countries;
using Basic.Api.Models.Domain;
using Core.Data.Domain.CommandHandlers;
using Core.Data.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YunTu.SDK;
using YunTu.SDK.Models;

namespace Basic.Api.Application.CommandHandlers.Countries
{
    public class AsyncCountryCommandHandler : CommandHandler, IRequestHandler<AsyncCountryCommand, bool>
    {
        private readonly IRepository<Country> _countryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private YuntuClient _client;
        public AsyncCountryCommandHandler(IUnitOfWork uow, IRepository<Country> countryRepository, YuntuClient client) : base(uow)
        {
            _countryRepository = countryRepository;
            _unitOfWork = uow;
            _client = client;
        }
        public async Task<bool> Handle(AsyncCountryCommand request, CancellationToken cancellationToken)
        {
            var coutries=await _client.GetRequestAsync<BaseResponse<List<CountryReponse>>>(new CountryRequest("C06901", "3VniAsdO6mU="));
            foreach (var item in coutries.Items)
            {
                Country country = new Country();
                country.Code = item.CountryCode;
                country.EName = item.EName;
                country.TwoCode = item.CountryCode;
                country.CName = item.CName;
                _countryRepository.Add(country);
            }
            return await _unitOfWork.CommitAsync();
        }
    }
}
