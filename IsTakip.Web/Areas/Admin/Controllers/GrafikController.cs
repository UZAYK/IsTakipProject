using IsTakip.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IsTakip.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GrafikController : Controller
    {
        private readonly IAppUserService _appUserService;
        public GrafikController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "grafik";

            return View();
        }
        public IActionResult EnCokTamamlayan()
        {
          var jsonString = JsonConvert.SerializeObject(_appUserService.GetirEnCokGorevTamamlamisPersoneller());
            return Json(jsonString);
        }
        public IActionResult EnCokCalisan()
        {
            var jsonString = JsonConvert.SerializeObject(_appUserService.GetirEnCokGorevdeCalisanPersoneller());
            return Json(jsonString);
        }
    }
}
