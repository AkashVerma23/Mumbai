using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Synergy.ViewComponents
{
    public class LanguageSwitcherViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var currentCulture = HttpContext.Features.Get<IRequestCultureFeature>()?.RequestCulture.Culture.Name;
            var languages = new[]
            {
                new { Code = "en", Name = "English" },
                new { Code = "hi", Name = "हिंदी" },
                // Add more languages as needed
            };

            ViewBag.CurrentCulture = currentCulture;
            return View(languages);
        }
    }
}