﻿using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

namespace UrlsAndRoutes.Controllers {
    public class CustomerController : Controller {
        [Route("[controller]/MyAction")]
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
            r.Data["carchall"] = RouteData.Values["catchall"];
            return View("Result", r);
        }
    }
}