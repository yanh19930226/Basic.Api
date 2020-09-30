using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Domain
{
    public class Company
    {
        public Company(){
            Shops = new List<Shop>();
        }

        public long Id { get; set; }

        public string Name { get; set; } 

        public string SkuPrefix { get; set; } 

        public decimal AdditionalFee { get; set; }
        public List<Shop> Shops { get; set; }

    }
}
