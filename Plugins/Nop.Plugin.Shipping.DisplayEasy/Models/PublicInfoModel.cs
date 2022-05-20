using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Shipping.DisplayEasy.Models
{
    public record PublicInfoModel : BaseNopModel
    {
        public int Id { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.DisplayEasy.Name")]
        public string Name { get; set; }
        [NopResourceDisplayName("Plugins.Shipping.DisplayEasy.EstimatedDelivery")]
        public string EstimatedDelivery { get; set; }
        
        [NopResourceDisplayName("Plugins.Shipping.DisplayEasy.Price")]
        public string Price { get; set; }

    }
}
