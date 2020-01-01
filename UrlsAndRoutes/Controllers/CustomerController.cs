using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

namespace UrlsAndRoutes.Controllers {
    [Route("app/[controller]/actions/[action]/{id?}")]
    public class CustomerController : Controller {
        public ViewResult Index() => View("Result",
            new Result {
                Controller = nameof(CustomerController),
                Action = nameof(Index)
            });

        public ViewResult List(string id) {
            Result r = new Result {
                Controller = nameof(HomeController),
                Action = nameof(List)
            };
            r.Data["Id"] = id ?? "<no value>";
            return View("Result", r);
        }
    }
}
