using IsTakip.Business.Interfaces;
using IsTakip.Web.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IsTakip.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class GrafikController : Controller
    {
        #region CTOR
        private readonly IAppUserService _appUserService;
        public GrafikController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            TempData["Active"] = TempdataInfo.Grafik;

            return View();
        }
        #endregion

        #region En Çok Görev Tamamlayan Kullanıcı
        public IActionResult EnCokTamamlayan()
        {
            var jsonString = JsonConvert.SerializeObject(_appUserService.GetirEnCokGorevTamamlamisPersoneller());
            return Json(jsonString);
        }
        #endregion

        #region En Çok Çalışan Kullanıcı
        public IActionResult EnCokCalisan()
        {
            var jsonString = JsonConvert.SerializeObject(_appUserService.GetirEnCokGorevdeCalisanPersoneller());
            return Json(jsonString);
        } 
        #endregion
    }
}
