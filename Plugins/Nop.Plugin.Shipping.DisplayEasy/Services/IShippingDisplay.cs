using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Shipping;
using Nop.Plugin.Shipping.DisplayEasy.Models;
using Nop.Services.Shipping;
using Nop.Services.Shipping.Tracking;

namespace Nop.Plugin.Shipping.DisplayEasy.Services
{
    public partial interface IShippingDisplay
    {
        Task<GetShippingOptionResponse> GetShippingDisplayAsync(GetShippingOptionRequest getShippingOptionRequest);

    }
}
