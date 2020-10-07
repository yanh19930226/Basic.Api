using Core.Data.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Commands.Shops
{
    public class DeleteShopCommand : Command
    {
        public DeleteShopCommand(long id)
        {
            Id = id;
        }
        public long Id { get; set; }
    }
}
