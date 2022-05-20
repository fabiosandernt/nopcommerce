using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Shipping.DisplayEasy.Models;
using Nop.Services.Shipping;

namespace Nop.Plugin.Shipping.DisplayEasy.Services
{
    public class ShippingDisplayService : IShippingDisplay 
    {     
        public async Task<GetShippingOptionResponse> GetShippingDisplayAsync(GetShippingOptionRequest getShippingOptionRequest)
        {
           
            var model = new PublicInfoModel()
            {
                Name = getShippingOptionRequest.Customer.Username,
                Price = getShippingOptionRequest.Items.Sum(x => x.Product.Price).ToString()              
            };

            var response = new GetShippingOptionResponse();

            response.ShippingOptions.Add(new Core.Domain.Shipping.ShippingOption
            {
                Name=getShippingOptionRequest.Customer.Username,
                DisplayOrder = getShippingOptionRequest.Items.Count(),
                
            });


            return await Task.FromResult(response); 
        }
              
    } 
}
