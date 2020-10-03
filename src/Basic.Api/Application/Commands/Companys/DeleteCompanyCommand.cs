using Core.Data.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Commands.Companys
{
    public class DeleteCompanyCommand : Command
    {
        public  DeleteCompanyCommand(long id)
        {
            id = Id;
        }
        public long Id { get; set; }
    }
}
