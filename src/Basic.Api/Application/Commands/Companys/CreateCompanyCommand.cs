using Core.Data.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Commands.Companys
{
    public class CreateCompanyCommand: Command
    {
        public  CreateCompanyCommand(string name, string skuPrefix, decimal additionalFee)
        {
            Name = name;
            SkuPrefix = skuPrefix;
            AdditionalFee = additionalFee;
        }
        public string Name { get; set; }

        public string SkuPrefix { get; set; }

        public decimal AdditionalFee { get; set; }
    }
}
