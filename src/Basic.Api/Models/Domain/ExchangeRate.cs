using Core.Data.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Domain
{
    public class ExchangeRate : Entity
    {
        public String CurrencyCode { get; set; } 

        public decimal ToUSD { get; set; } = decimal.MinValue;
    }
}
