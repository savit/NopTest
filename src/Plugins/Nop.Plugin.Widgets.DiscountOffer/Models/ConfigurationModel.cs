using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.DiscountOffer.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.DiscountOffer.Text")]
        public string TextMessage { get; set; }
        public bool TextMessage_OverrideForStore { get; set; }
    }
}