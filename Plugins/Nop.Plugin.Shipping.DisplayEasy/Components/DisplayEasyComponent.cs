using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Services.Configuration;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Shipping.DisplayEasy.Components
{
    [ViewComponent(Name = "DisplayEasy")]
    public class DisplayEasyComponent: NopViewComponent
    {
        private readonly ISettingService _settingService;
        private readonly IStoreContext _storeContext;

        public DisplayEasyComponent(ISettingService settingService, IStoreContext storeContext)
        {
            _settingService = settingService;
            _storeContext = storeContext;
        }
        public IViewComponentResult Invoke(string widgetZone, object additionalData)        {

            

            //return View("../Plugins/Nop.Plugin.Shipping.DisplayEasy/Views/PublicInfo.cshtml");
            return Content("MINHA TABELA");
        }
    }
}
