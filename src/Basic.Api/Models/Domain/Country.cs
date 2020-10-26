using Core.Data.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Domain
{
    public class Country:Entity
    {
        public string Code { get; set; }
        public string TwoCode { get; set; }
        public string EName { get; set; }
        public string CName { get; set; }
    }
}
