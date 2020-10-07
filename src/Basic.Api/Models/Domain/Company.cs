using Core.Data.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Domain
{
    public class Company : Entity
    {
        public Company(){
            Shops = new List<Shop>();
        }

        public string Name { get; set; } 

        public string SkuPrefix { get; set; } 

        public decimal AdditionalFee { get; set; }
        public List<Shop> Shops { get; set; }

    }
}
