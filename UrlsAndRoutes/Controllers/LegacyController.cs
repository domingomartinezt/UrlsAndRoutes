using Microsoft.AspNetCore.Mvc;

namespace UrlsAndRoutes.Controllers {
    public class LegacyController : Controller{
        public ViewResult GetLegacyUrl(string LegacyUrl) => View((object)LegacyUrl);

    }
}
