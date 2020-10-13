using Basic.Api.Application.Commands.ExchangeRates;
using Basic.Api.Models.Domain;
using Core.Data.Domain.CommandHandlers;
using Core.Data.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Basic.Api.Application.CommandHandlers.ExchangeRates
{
    public class AsyncExchangeRateCommandHandler : CommandHandler, IRequestHandler<AsyncExchangeRateCommand, bool>
    {
        private readonly IRepository<ExchangeRate> _exchangeRateRepository;
        private readonly IUnitOfWork _unitOfWork;
        public AsyncExchangeRateCommandHandler(IUnitOfWork uow, IRepository<ExchangeRate> exchangeRateRepository) : base(uow)
        {
            _exchangeRateRepository = exchangeRateRepository;
            _unitOfWork = uow;
        }
        public async Task<bool> Handle(AsyncExchangeRateCommand request, CancellationToken cancellationToken)
        {
            Rates RatesInfo = null;
            using (WebClient web = new WebClient())
            {
                 RatesInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<Rates>(web.DownloadString("https://api.exchangerate-api.com/v4/latest/USD"));
            }
            try
            {
                _exchangeRateRepository.ExecuteSql("delete from ExchangeRate where 1 = 1  ");
                foreach (var r in RatesInfo.rates)
                {
                    var rate = new ExchangeRate { CurrencyCode = r.Key, ToUSD = r.Value };
                    _exchangeRateRepository.Add(rate);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return await _unitOfWork.CommitAsync();
        }
    }
    public class Rates
    {
        public IDictionary<string, decimal> rates { get; set; } = new Dictionary<string, decimal>();
    }
}
