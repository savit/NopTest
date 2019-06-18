using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Widgets.DiscountOffer.Models;
using Nop.Services.Configuration;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.DiscountOffer.Components
{
    [ViewComponent(Name = "WidgetsDiscountOffer")]
    public class WidgetsDiscountOfferViewComponent : NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly ISettingService _settingService;

        public WidgetsDiscountOfferViewComponent(IStoreContext storeContext, ISettingService settingService)
        {
            _storeContext = storeContext;
            _settingService = settingService;
        }

        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            var discountOfferSettings = _settingService.LoadSetting<DiscountOfferSettings>(_storeContext.CurrentStore.Id);

            var model = new PublicInfoModel
            {
                TextMessage = discountOfferSettings.TextMessage
            };
            return View("~/Plugins/Widgets.DiscountOffer/Views/PublicInfo.cshtml", model);
        }
    }
}
