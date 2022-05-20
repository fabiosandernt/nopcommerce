using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Plugin.Shipping.DisplayEasy.Models;
using Nop.Plugin.Shipping.DisplayEasy.Services;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Orders;
using Nop.Services.Plugins;
using Nop.Services.Shipping;
using Nop.Services.Shipping.Tracking;

namespace Nop.Plugin.Shipping.DisplayEasy
{
    public class DisplayEasyPlugin : BasePlugin, IShippingRateComputationMethod, IWidgetPlugin
    {

        private readonly IWebHelper _webHelper;        
        private readonly ISettingService _settingService;
        private readonly ILocalizationService _localizationService;
        private readonly IShippingService _shippingService;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IShippingDisplay _ishippingDisplay;
        private readonly IStoreContext _storeContext;



        public DisplayEasyPlugin(IStoreContext storeContext, IShippingDisplay ishippingDisplay, IShoppingCartService shoppingCartService, IShippingService shippingService, IWebHelper webHelper, ISettingService settingService, ILocalizationService localizationService)
        {
            _webHelper = webHelper;       
            _settingService = settingService;
            _localizationService = localizationService;
            _shippingService = shippingService; 
            _shoppingCartService = shoppingCartService;
            _ishippingDisplay = ishippingDisplay;
            _storeContext = storeContext;

        }
        public bool HideInWidgetList => false;

        public Task<decimal?> GetFixedRateAsync(GetShippingOptionRequest getShippingOptionRequest)
        {
            throw new NotImplementedException();
        }

        public Task<IShipmentTracker> GetShipmentTrackerAsync()
        {
            return Task.FromResult<IShipmentTracker>(null);
        }

        public async  Task<GetShippingOptionResponse> GetShippingOptionsAsync(GetShippingOptionRequest getShippingOptionRequest)
        {

            return await _ishippingDisplay.GetShippingDisplayAsync(getShippingOptionRequest);
         

        }
       
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "DisplayEasy";
        }

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string> { "order_summary_totals" } );
        }

        public override async Task InstallAsync()
        {

            await _localizationService.AddOrUpdateLocaleResourceAsync(new Dictionary<string, string>
            {
                ["Plugin.Misc.EasyComTecGeneralRegister.Name"] = "Nome",
           
            });


            await base.InstallAsync();
        }

        public override async Task UninstallAsync()
        {
                             
            await _localizationService.DeleteLocaleResourcesAsync("Plugin.Shipping.DisplayEasy");

            await base.UninstallAsync();
        }

        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/Configuration/Configure";
        }

    }
}
