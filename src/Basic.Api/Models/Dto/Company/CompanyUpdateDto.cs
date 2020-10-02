﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Dto.Company
{
    public class CompanyUpdateDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string SkuPrefix { get; set; }

        public decimal AdditionalFee { get; set; }
    }
}
